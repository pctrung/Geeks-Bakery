using AutoMapper;
using GeeksBakery.Application.Interfaces;
using GeeksBakery.Data.EF;
using GeeksBakery.Data.Entities;
using GeeksBakery.Utilities.Exceptions;
using GeeksBakery.Utilities.Extensions;
using GeeksBakery.ViewModels.Catalog.CakeImage;
using GeeksBakery.ViewModels.Common;
using GeeksBakery.ViewModels.Requests.Cake;
using GeeksBakery.ViewModels.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeeksBakery.Application.Services
{
    public class CakeService : ICakeService
    {
        private readonly GeeksBakeryDbContext _context;
        private readonly IMapper _mapper;
        private readonly ICakeImageService _cakeImageService;

        public CakeService(GeeksBakeryDbContext context, ICakeImageService cakeImageService, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
            _cakeImageService = cakeImageService;
        }

        public async Task<int> CreateAsync(CakeCreateRequest request)
        {
            var cake = _mapper.Map<Cake>(request);
            cake.DateCreated = DateTime.Now;

            if (request.CakeImages != null)
            {
                foreach (var cakeImage in request.CakeImages)
                {
                    await _cakeImageService.CreateAsync(cakeImage);
                }
            }
            await _context.Cakes.AddAsync(cake);
            await _context.SaveChangesAsync();
            return cake.Id;
        }

        public async Task<int> UpdateAsync(CakeUpdateRequest request)
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
            cake.Slug = request.Slug;
            cake.Stock = request.Stock;
            cake.Description = request.Description;
            cake.CategoryId = request.CategoryId;
            cake.DateModified = DateTime.Now;

            if (request.CakeImages != null)
            {
                foreach (var cakeImage in request.CakeImages)
                {
                    await _cakeImageService.UpdateAsync(cakeImage);
                }
            }

            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int cakeId)
        {
            var cake = await _context.Cakes.Where(x => x.Id == cakeId).Include(x => x.CakeImages).FirstOrDefaultAsync();

            if (cake == null)
            {
                throw new GeeksBakeryException($"Cannot find cake with Id: {cakeId}");
            }

            cake.CakeImages.ForEach(async image => await _cakeImageService.DeleteAsync(image.Id));

            _context.Cakes.Remove(cake);

            return await _context.SaveChangesAsync();
        }

        public async Task<CakeViewModel> GetByIdAsync(int cakeId)
        {
            //get all
            var result = await _context.Cakes.Where(x => x.Id == cakeId).Include(x => x.Category).Include(x => x.CakeImages).Include(x => x.Rates).Select(
                cake => new CakeViewModel()
                {
                    CategoryId = cake.Category.Id,
                    CategoryName = cake.Category.Name,
                    Id = cake.Id,
                    Name = cake.Name,
                    Description = cake.Description,
                    Price = cake.Price,
                    OriginalPrice = cake.OriginalPrice,
                    SEOAlias = cake.Slug,
                    Size = cake.Size,
                    Stock = cake.Stock,
                    CakeImages = _mapper.Map<List<CakeImageViewModel>>(cake.CakeImages),
                    Rates = _mapper.Map<List<RateViewModel>>(cake.Rates)
                }).FirstOrDefaultAsync();

            return result;
        }

        public async Task<PagedResult<CakeViewModel>> GetAllPagingAsync(GetCakePagingRequest request)
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
                SEOAlias = cake.Slug,
                Size = cake.Size,
                Stock = cake.Stock,
                CakeImages = _mapper.Map<List<CakeImageViewModel>>(cake.CakeImages),
                Rates = _mapper.Map<List<RateViewModel>>(cake.Rates)
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

            if (request.PageSize > 0)
            {
                request.PageIndex = request.PageIndex > 0 ? request.PageIndex : 1;

                //result = result.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize);
                result = result.Paged(request.PageIndex, request.PageSize);
            }

            var data = await result.ToListAsync();

            var pagedResult = new PagedResult<CakeViewModel>()
            {
                TotalRecord = totalRow,
                Items = data
            };

            return pagedResult;
        }
    }
}