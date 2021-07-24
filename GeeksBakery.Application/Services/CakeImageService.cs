using AutoMapper;
using GeeksBakery.Application.Interfaces;
using GeeksBakery.Data.EF;
using GeeksBakery.Data.Entities;
using GeeksBakery.Utilities.Exceptions;
using GeeksBakery.ViewModels.Catalog.CakeImage;
using GeeksBakery.ViewModels.Requests.CakeImage;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace GeeksBakery.Application.Services
{
    public class CakeImageService : ICakeImageService
    {
        private readonly GeeksBakeryDbContext _context;
        private readonly IStorageService _storageService;
        private readonly IMapper _mapper;

        public CakeImageService(GeeksBakeryDbContext context, IStorageService storageService, IMapper mapper)
        {
            _context = context;
            _storageService = storageService;
            _mapper = mapper;
        }

        public async Task<int> CreateAsync(CakeImageCreateRequest request)
        {
            var cake = await _context.Cakes.FindAsync(request.CakeId);
            if (cake == null)
            {
                throw new GeeksBakeryException("Cannot find cake with Id: " + request.CakeId);
            }
            if (request.ImageFile != null)
            {
                var cakeImage = new CakeImage()
                {
                    CakeId = request.CakeId,
                    FileName = await SaveFileAsync(request.ImageFile),
                    Caption = request.Caption,
                    IsDefault = request.IsDefault,
                    DateCreated = DateTime.Now,
                    SortOrder = request.SortOrder,
                    FileSize = request.ImageFile.Length
                };

                cake.DateModified = DateTime.Now;

                _context.CakeImages.Add(cakeImage);
                await _context.SaveChangesAsync();
                return cakeImage.Id;
            }
            return -1;
        }

        public async Task<int> UpdateAsync(CakeImageUpdateRequest request, int cakeId)
        {
            var cake = await _context.Cakes.FindAsync(cakeId);

            var cakeImage = await _context.CakeImages.FindAsync(request.Id);

            if (cake == null)
            {
                throw new GeeksBakeryException($"Cannot find cake with Id = {cakeId}");
            }
            if (cakeImage == null)
            {
                throw new GeeksBakeryException($"Cannot find image with Id = {request.Id}");
            }
            else if (cakeId != 0 && cakeId != cakeImage.CakeId)
            {
                throw new GeeksBakeryException($"Cannot find image with Id = {request.Id} in cake Id = {cakeId}");
            }
            if (request.ImageFile != null)
            {
                await _storageService.DeleteFileAsync(cakeImage.FileName);
                cakeImage.FileName = await SaveFileAsync(request.ImageFile);
                cakeImage.FileSize = request.ImageFile.Length;
            }

            cakeImage.Caption = request.Caption;
            cakeImage.IsDefault = request.IsDefault;
            cakeImage.SortOrder = request.SortOrder;

            cake.DateModified = DateTime.Now;

            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int cakeImageId, int cakeId = 0)
        {
            var cakeImage = await _context.CakeImages.Where(x => x.Id == cakeImageId).FirstOrDefaultAsync();

            var cake = await _context.Cakes.FindAsync(cakeId);

            if (cake == null)
            {
                throw new GeeksBakeryException($"Cannot find cake with Id = {cakeId}");
            }

            if (cakeImage == null)
            {
                throw new GeeksBakeryException($"Cannot find image with Id: {cakeImageId}");
            }
            else if (cakeId != 0 && cakeId != cakeImage.CakeId)
            {
                throw new GeeksBakeryException($"Cannot find image with Id = {cakeImageId} in cake Id = {cakeId}");
            }

            await _storageService.DeleteFileAsync(cakeImage.FileName);

            cake.DateModified = DateTime.Now;

            _context.CakeImages.Remove(cakeImage);

            return await _context.SaveChangesAsync();
        }

        public async Task<CakeImageViewModel> GetByIdAsync(int cakeImageId, int cakeId = 0)
        {
            //get all
            var result = _mapper.Map<CakeImageViewModel>(await _context.CakeImages.Where(x => x.Id == cakeImageId).FirstOrDefaultAsync());

            if (result != null && cakeId != 0 && cakeId != result.CakeId)
            {
                result = null;
            }

            return result;
        }

        public async Task<List<CakeImageViewModel>> GetByCakeIdAsync(int cakeId)
        {
            List<CakeImageViewModel> result;
            //get all if cake id = 0
            if (cakeId == 0)
            {
                result = _mapper.Map<List<CakeImageViewModel>>(await _context.CakeImages.ToListAsync());
            }
            else //else get by cake Id
            {
                result = _mapper.Map<List<CakeImageViewModel>>(await _context.CakeImages.Where(x => x.CakeId == cakeId).ToListAsync());
            }

            return result;
        }

        private async Task<string> SaveFileAsync(IFormFile file)
        {
            if (file == null)
            {
                throw new GeeksBakeryException("Cannot add null file");
            }
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }
    }
}