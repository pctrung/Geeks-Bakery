using GeeksBakery.ViewModels.Requests.Rate;
using GeeksBakery.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.Application.Interfaces
{
    public interface IRateService
    {
        Task<int> CreateAsync(RateCreateRequest request);

        Task<int> DeleteAsync(int rateId);

        Task<List<RateViewModel>> GetByCakeIdAsync(int cakeId);

        Task<RateViewModel> GetByIdAsync(int rateId);
    }
}