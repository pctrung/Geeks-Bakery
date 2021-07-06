using GeeksBakery.Application.Common;
using GeeksBakery.Data.EF;
using GeeksBakery.Data.Entities;
using GeeksBakery.Utilities.Exceptions;
using GeeksBakery.ViewModels.Catalog.CakeImage;
using GeeksBakery.ViewModels.Catalog.Cakes.Dtos;
using GeeksBakery.ViewModels.Catalog.Dtos;
using GeeksBakery.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace GeeksBakery.Application.Catalog.Cakes
{
    public class CakeService : ICakeService
    {
        private readonly GeeksBakeryDbContext _context;
        private readonly IStorageService _storageService;

        public CakeService(GeeksBakeryDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }
        public async Task<int> Create(CakeCreateRequest request)
        {
            var cake = new Cake()
            {
                Name = request.Name,
                CategoryId = request.CategoryId,
                DateCreated = DateTime.Now,
                Description = request.Description,
                OriginalPrice = request.OriginalPrice,
                Price = request.Price,
                Size = request.Size,
                Stock = request.Stock,
                SEOAlias = request.SEOAlias
            };
            if (request.Thumbnail != null)
            {
                cake.CakeImages = new List<CakeImage>()
                {
                    new CakeImage
                    {
                        Caption = "Thumbnail image",
                        DateCreated = DateTime.Now,
                        FileSize = request.Thumbnail.Length,
                        FileName = await SaveFile(request.Thumbnail),
                        IsDefault = true,
                        SortOrder = 1
                    }
                };
            }
            _context.Cakes.Add(cake);
            await _context.SaveChangesAsync();
            return cake.Id;
        }

        public async Task<int> Update(CakeUpdateRequest request)
        {
            var cake = await _context.Cakes.FindAsync(request.Id);

            if (cake == null)
            {
                throw new GeeksBakeryException($"Cannot find cake with Id = {request.Id}");
            }

            cake.Name = request.Name;
            cake.Price = request.Price;
            cake.OriginalPrice = request.OriginalPrice;
            cake.Size = request.Size;
            cake.SEOAlias = request.SEOAlias;
            cake.Stock = request.Stock;
            cake.Description = request.Description;
            cake.CategoryId = request.CategoryId;
            cake.DateModified = DateTime.Now;

            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int cakeId)
        { 
            var cake = await _context.Cakes.Where(x => x.Id == cakeId).Include(x => x.CakeImages).FirstOrDefaultAsync();

            if (cake == null)
            {
                throw new GeeksBakeryException($"Cannot find cake with Id: {cakeId}");
            }

            cake.CakeImages.ForEach(async image => await _storageService.DeleteFileAsync(image.FileName));

            _context.Cakes.Remove(cake);

            return await _context.SaveChangesAsync();
        }
        public async Task<CakeViewModel> GetById(int cakeId)
        {

            //get all
            var result = await _context.Cakes.Where(x => x.Id == cakeId).Include(x => x.Category).Include(x => x.CakeImages).Select(
                cake => new CakeViewModel()
                {
                    CategoryId = cake.Category.Id,
                    CategoryName = cake.Category.Name,
                    Id = cake.Id,
                    Name = cake.Name,
                    Description = cake.Description,
                    Price = cake.Price,
                    OriginalPrice = cake.OriginalPrice,
                    SEOAlias = cake.SEOAlias,
                    Size = cake.Size,
                    Stock = cake.Stock,
                    CakeImages = cake.CakeImages.Select(
                        image => new CakeImageViewModel() {
                            Caption = image.Caption,
                            Id = image.Id,
                            FileName = image.FileName,
                            IsDefault = image.IsDefault,
                            SortOrder = image.SortOrder
                        }).ToList()
                }).FirstOrDefaultAsync();

            return result;
        }
        public async Task<PagedResult<CakeViewModel>> GetAllPaging(GetCakePagingRequest request)
        {
            //get all
            var result = _context.Cakes.Include(x => x.Category).Include(x => x.CakeImages).Select(cake => new CakeViewModel()
                {
                    CategoryId = cake.Category.Id,
                    CategoryName = cake.Category.Name,
                    Id = cake.Id,
                    Name = cake.Name,
                    Description = cake.Description,
                    Price = cake.Price,
                    OriginalPrice = cake.OriginalPrice,
                    SEOAlias = cake.SEOAlias,
                    Size = cake.Size,
                    Stock = cake.Stock,
                    CakeImages = cake.CakeImages.Select(
                        image => new CakeImageViewModel()
                        {
                            Caption = image.Caption,
                            Id = image.Id,
                            FileName = image.FileName,
                            IsDefault = image.IsDefault,
                            SortOrder = image.SortOrder
                        }).ToList()
            });

            // filter
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                result = result.Where(p => p.Name.Contains(request.Keyword));
            }
            if (request.CategoryIds?.Count > 0)
            {
                result = result.Where(p => request.CategoryIds.Contains(p.CategoryId));
            }

            int totalRow = await result.CountAsync();

            if(request.PageSize > 0)
            {
                request.PageIndex = request.PageIndex > 0 ? request.PageIndex : 1;

                result = result.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize);
            }

            var data = await result.ToListAsync();

            var pagedResult = new PagedResult<CakeViewModel>()
            {
                TotalRecord = totalRow,
                Items = data
            };

            return pagedResult;
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }
    }
}
