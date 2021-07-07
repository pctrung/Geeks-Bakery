using GeeksBakery.ViewModels.Common;
using GeeksBakery.ViewModels.Requests.Cake;
using GeeksBakery.ViewModels.ViewModels;
using System.Threading.Tasks;

namespace GeeksBakery.Application.Interfaces
{
    public interface ICakeService
    {
        Task<int> CreateAsync(CakeCreateRequest request);

        Task<int> UpdateAsync(CakeUpdateRequest request);

        Task<int> DeleteAsync(int cakeId);

        Task<PagedResult<CakeViewModel>> GetAllPagingAsync(GetCakePagingRequest request);

        Task<CakeViewModel> GetByIdAsync(int cakeId);
    }
}