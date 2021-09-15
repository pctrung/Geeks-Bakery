using GeeksBakery.ViewModels.Requests.Category;
using GeeksBakery.ViewModels.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeeksBakery.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<int> CreateAsync(CategoryCreateRequest request);

        Task<int> UpdateAsync(CategoryUpdateRequest request);

        Task<int> DeleteAsync(int categoryId);

        Task<List<CategoryViewModel>> GetAllAsync();

        Task<CategoryViewModel> GetByIdAsync(int categoryId);
    }
}