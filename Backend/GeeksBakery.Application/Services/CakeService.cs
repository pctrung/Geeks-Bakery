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
using Microsoft.Extensions.Configuration;
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
        private readonly IConfiguration _configuration;

        private const int DEFAULT_LIMIT = 999;
        private const int DEFAULT_PAGE_INDEX = 1;

        public CakeService(GeeksBakeryDbContext context, ICakeImageService cakeImageService, IMapper mapper, IConfiguration configuration)
        {
            _mapper = mapper;
            _context = context;
            _cakeImageService = cakeImageService;
            _configuration = configuration;
        }

        public async Task<int> CreateAsync(CakeCreateRequest request)
        {
            var cake = _mapper.Map<Cake>(request);
            cake.DateCreated = DateTime.Now;

            await _context.Cakes.AddAsync(cake);

            // not available now
            //if (request.CakeImageIds?.Count > 0)
            //{
            //    await _context.CakeImages.Where(x => request.CakeImageIds.Contains(x.Id)).ForEachAsync(x => x.CakeId = cake.Id);
            //}

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

            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int cakeId)
        {
            var cake = await _context.Cakes.Where(x => x.Id == cakeId).Include(x => x.CakeImages).FirstOrDefaultAsync();

            if (cake == null)
            {
                throw new GeeksBakeryException($"Cannot find cake with Id: {cakeId}");
            }

            foreach (var image in cake.CakeImages.ToList())
            {
                await _cakeImageService.DeleteAsync(image.Id, cakeId);
            }

            _context.Cakes.Remove(cake);

            return await _context.SaveChangesAsync();
        }

        public async Task<CakeViewModel> GetByIdAsync(int cakeId)
        {
            //get all
            var result = await _context.Cakes.Where(x => x.Id == cakeId)
                .Include(x => x.Category)
                .Include(x => x.CakeImages)
                .Include(x => x.Reviews)
                .ThenInclude(review => review.User).Select(
                cake => new CakeViewModel()
                {
                    CategoryId = cake.Category.Id,
                    CategoryName = cake.Category.Name,
                    Id = cake.Id,
                    Name = cake.Name,
                    Description = cake.Description,
                    Price = cake.Price,
                    OriginalPrice = cake.OriginalPrice,
                    Slug = cake.Slug,
                    Size = cake.Size,
                    Stock = cake.Stock,
                    DateModified = cake.DateModified,
                    DateCreated = cake.DateCreated,
                    CakeImages = _mapper.Map<List<CakeImageViewModel>>(cake.CakeImages),
                    Reviews = _mapper.Map<List<ReviewViewModel>>(cake.Reviews)
                }).AsSplitQuery().OrderBy(x => x.Id).FirstOrDefaultAsync();

            if (result != null && result.Reviews != null)
            {
                for (var i = 0; i < result.Reviews.Count; i++)
                {
                    result.Reviews[i].UserAvatar = _configuration.GetValue<string>("Url:ImagesUrl") + "/" + result.Reviews[i].UserAvatar;
                }
            }

            if (result != null && result.Reviews != null && result.Reviews.Count > 0)
            {
                result.AvgStar = result.Reviews.Average(x => x.Star);
            }

            return result;
        }

        public async Task<PagedResult<CakeViewModel>> GetAllPagingAsync(GetCakePagingRequest request)
        {
            //get all
            var result = _context.Cakes.Include(x => x.Category)
                .Include(x => x.CakeImages)
                .Select(cake => new CakeViewModel()
                {
                    CategoryId = cake.Category.Id,
                    CategoryName = cake.Category.Name,
                    Id = cake.Id,
                    Name = cake.Name,
                    Description = cake.Description,
                    Price = cake.Price,
                    OriginalPrice = cake.OriginalPrice,
                    Slug = cake.Slug,
                    Size = cake.Size,
                    Stock = cake.Stock,
                    DateModified = cake.DateModified,
                    DateCreated = cake.DateCreated,
                    CakeImages = cake.CakeImages == null ? null : _mapper.Map<List<CakeImageViewModel>>(cake.CakeImages)
                }).AsSplitQuery();

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

            // set limit, page index default = 999
            request.Limit = request.Limit > 0 ? request.Limit : DEFAULT_LIMIT;

            request.Page = request.Page > 0 ? request.Page : 1;

            // extention method paged
            result = result.OrderBy(x => x.Id).Paged(request.Page, request.Limit);

            var data = result.ToList();

            // select category name from request category

            List<string> categoryNames = new List<string>();

            if (request.CategoryIds != null)
            {
                foreach (var id in request.CategoryIds)
                {
                    var category = _context.Categories.First(x => x.Id == id);
                    categoryNames.Add(category.Name);
                }
            }

            var pagedResult = new PagedResult<CakeViewModel>()
            {
                TotalRecords = totalRow,
                Items = data,
                Keyword = request.Keyword,
                Page = request.Page,
                Limit = request.Limit,
                CategoryNames = categoryNames,
                CategoryIds = request.CategoryIds
            };

            return pagedResult;
        }

        public async Task<List<CakeViewModel>> GetBestSellerCakesAsync(int take)
        {
            var query = from cake in _context.Cakes
                        join review in _context.Reviews on cake.Id equals review.CakeId
                        group new { cake, review } by new { cake.Id, cake.Name, cake.OriginalPrice, cake.Price } into g
                        select new
                        {
                            g.Key.Id,
                            g.Key.Name,
                            g.Key.Price,
                            g.Key.OriginalPrice,
                            avgStart = g.Average(x => x.review.Star)
                        };

            var data = query.OrderByDescending(x => x.avgStart).Take(take).ToList();

            var result = new List<CakeViewModel>();
            foreach (var cake in data)
            {
                var temp = new CakeViewModel()
                {
                    Id = cake.Id,
                    Name = cake.Name,
                    CakeImages = await _cakeImageService.GetByCakeIdAsync(cake.Id),
                    Price = cake.Price,
                    OriginalPrice = cake.OriginalPrice,
                    AvgStar = cake.avgStart
                };
                result.Add(temp);
            }

            return result;
        }

        private class StarResult
        {
            public int StarAvg { get; set; }
            public int cakeId { get; set; }
        }
    }
}