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
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.Application.Services
{
    public class CakeImageService : ICakeImageService
    {
        private readonly GeeksBakeryDbContext _context;
        private readonly IStorageService _storageService;

        public CakeImageService(GeeksBakeryDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        public async Task<int> CreateAsync(CakeImageCreateRequest request)
        {
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
                    FileSize = request.FileSize
                };

                _context.CakeImages.Add(cakeImage);
                await _context.SaveChangesAsync();
                return cakeImage.Id;
            }
            return -1;
        }

        public async Task<int> UpdateAsync(CakeImageUpdateRequest request)
        {
            var cakeImage = await _context.CakeImages.FindAsync(request.Id);

            if (cakeImage == null)
            {
                throw new GeeksBakeryException($"Cannot find cake with Id = {request.Id}");
            }

            cakeImage.CakeId = request.CakeId;
            cakeImage.FileName = await SaveFileAsync(request.ImageFile);
            cakeImage.Caption = request.Caption;
            cakeImage.IsDefault = request.IsDefault;
            cakeImage.DateCreated = DateTime.Now;
            cakeImage.SortOrder = request.SortOrder;
            cakeImage.FileSize = request.FileSize;

            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int cakeImageId)
        {
            var cakeImage = await _context.CakeImages.Where(x => x.Id == cakeImageId).FirstOrDefaultAsync();

            if (cakeImage == null)
            {
                throw new GeeksBakeryException($"Cannot find cake with Id: {cakeImageId}");
            }

            _context.CakeImages.Remove(cakeImage);

            return await _context.SaveChangesAsync();
        }

        public async Task<CakeImageViewModel> GetByIdAsync(int cakeImageId)
        {
            //get all
            var result = await _context.CakeImages.Where(x => x.Id == cakeImageId).Select(
                cakeImage => new CakeImageViewModel()
                {
                    Id = cakeImage.Id,
                    CakeId = cakeImage.CakeId,
                    FileName = cakeImage.FileName,
                    Caption = cakeImage.Caption,
                    IsDefault = cakeImage.IsDefault,
                    SortOrder = cakeImage.SortOrder
                }).FirstOrDefaultAsync();

            return result;
        }

        public async Task<List<CakeImageViewModel>> GetAllAsync(int cakeId)
        {
            //get all
            var result = await _context.CakeImages.Where(x => x.CakeId == cakeId).Select(cakeImage => new CakeImageViewModel()
            {
                Id = cakeImage.Id,
                CakeId = cakeImage.CakeId,
                FileName = cakeImage.FileName,
                Caption = cakeImage.Caption,
                IsDefault = cakeImage.IsDefault,
                SortOrder = cakeImage.SortOrder
            }).ToListAsync();

            return result;
        }

        private async Task<string> SaveFileAsync(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }
    }
}