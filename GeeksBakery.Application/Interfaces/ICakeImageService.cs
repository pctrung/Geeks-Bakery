using GeeksBakery.ViewModels.Catalog.CakeImage;
using GeeksBakery.ViewModels.Requests.CakeImage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.Application.Interfaces
{
    public interface ICakeImageService
    {
        Task<int> CreateAsync(CakeImageCreateRequest request);

        Task<int> UpdateAsync(CakeImageUpdateRequest request);

        Task<int> DeleteAsync(int cakeImageId);

        Task<List<CakeImageViewModel>> GetAllAsync(int cakeImageId);

        Task<CakeImageViewModel> GetByIdAsync(int cakeImageId);
    }
}