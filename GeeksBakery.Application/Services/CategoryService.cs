using AutoMapper;
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
        private readonly IMapper _mapper;

        public CategoryService(GeeksBakeryDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<int> CreateAsync(CategoryCreateRequest request)
        {
            if (string.IsNullOrEmpty(request.Name))
            {
                return 0;
            }
            var category = _mapper.Map<Category>(request);

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
            return await _context.Categories.Select(category => _mapper.Map<CategoryViewModel>(category)).ToListAsync();
        }

        public async Task<CategoryViewModel> GetByIdAsync(int categoryId)
        {
            var category = await _context.Categories.Where(x => x.Id == categoryId).Include(x => x.Cakes).FirstOrDefaultAsync();

            if (category == null)
            {
                throw new GeeksBakeryException($"Cannot find category with Id = {categoryId}");
            }

            return _mapper.Map<CategoryViewModel>(category);
        }
    }
}