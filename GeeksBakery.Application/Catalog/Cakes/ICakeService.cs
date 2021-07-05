using GeeksBakery.ViewModels.Catalog.Cakes.Dtos;
using GeeksBakery.ViewModels.Catalog.Dtos;
using GeeksBakery.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.Application.Catalog.Cakes
{
    public interface ICakeService
    {
        Task<int> Create(CakeCreateRequest request);
        Task<int> Update(CakeUpdateRequest request);
        Task<int> Delete(int cakeId);
        Task<PagedResult<CakeViewModel>> GetAllPaging(GetCakePagingRequest request);
        
    }
}
