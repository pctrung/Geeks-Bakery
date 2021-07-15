using GeeksBakery.ViewModels.Common;
using GeeksBakery.ViewModels.Requests.Cake;
using GeeksBakery.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeeksBakery.ClientSite.Interfaces
{
    public interface ICakeService
    {
        Task<PagedResult<CakeViewModel>> GetPagingsAsync(GetCakePagingRequest request);

        Task<List<CakeViewModel>> GetFeaturedProductsAsync();

        Task<List<CakeViewModel>> GetLatestProductsAsync();
    }
}