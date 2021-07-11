using GeeksBakery.Application.Interfaces;
using GeeksBakery.Data.EF;
using GeeksBakery.Data.Entities;
using GeeksBakery.Utilities.Exceptions;
using GeeksBakery.ViewModels.Requests.Category;
using GeeksBakery.ViewModels.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeeksBakery.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly GeeksBakeryDbContext _context;

        public CategoryService(GeeksBakeryDbContext context)
        {
            _context = context;
        }

        public async Task<int> CreateAsync(CategoryCreateRequest request)
        {
            var category = new Category()
            {
                Name = request.Name,
                ParentId = request.ParentId,
                Description = request.Description
            };
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category.Id;
        }

        public async Task<int> UpdateAsync(CategoryUpdateRequest request)
        {
            var category = await _context.Categories.FindAsync(request.Id);

            if (category == null)
            {
                throw new GeeksBakeryException($"Cannot find category with Id = {request.Id}");
            }

            category.Name = request.Name;
            category.ParentId = request.ParentId;
            category.Description = request.Description;

            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int categoryId)
        {
            var category = await _context.Categories.FindAsync(categoryId);

            if (category == null)
            {
                throw new GeeksBakeryException($"Cannot find category with Id = {categoryId}");
            }

            _context.Remove(category);

            return await _context.SaveChangesAsync();
        }

        public async Task<List<CategoryViewModel>> GetAllAsync()
        {
            return await _context.Categories.Select(category => new CategoryViewModel()
            {
                Id = category.Id,
                Name = category.Name,
                ParentId = category.ParentId,
                Description = category.Description
            }).ToListAsync();
        }

        public async Task<CategoryViewModel> GetByIdAsync(int categoryId)
        {
            var category = await _context.Categories.Where(x => x.Id == categoryId).Include(x => x.Cakes).FirstOrDefaultAsync();

            if (category == null)
            {
                throw new GeeksBakeryException($"Cannot find category with Id = {categoryId}");
            }

            return new CategoryViewModel()
            {
                Id = category.Id,
                Name = category.Name,
                ParentId = category.ParentId,
                Description = category.Description
                //Cakes = category.Cakes.Select(cake => new CakeViewModel()
                //{
                //    CategoryId = cake.Category.Id,
                //    CategoryName = cake.Category.Name,
                //    Id = cake.Id,
                //    Name = cake.Name,
                //    Description = cake.Description,
                //    Price = cake.Price,
                //    OriginalPrice = cake.OriginalPrice,
                //    SEOAlias = cake.Slug,
                //    Size = cake.Size,
                //    Stock = cake.Stock,
                //}).ToList()
            };
        }
    }
}