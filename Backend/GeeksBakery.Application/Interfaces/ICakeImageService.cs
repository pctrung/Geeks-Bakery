using GeeksBakery.ViewModels.Catalog.CakeImage;
using GeeksBakery.ViewModels.Requests.CakeImage;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeeksBakery.Application.Interfaces
{
    public interface ICakeImageService
    {
        Task<int> CreateAsync(CakeImageCreateRequest request);

        Task<int> UpdateAsync(CakeImageUpdateRequest request, int cakeId);

        Task<int> DeleteAsync(int cakeImageId, int cakeId);

        Task<List<CakeImageViewModel>> GetByCakeIdAsync(int cakeId);

        Task<CakeImageViewModel> GetByIdAsync(int cakeImageId, int cakeId);
    }
}