using GeeksBakery.ViewModels.Requests.Review;
using GeeksBakery.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.Application.Interfaces
{
    public interface IReviewService
    {
        Task<int> CreateAsync(ReviewCreateRequest request);

        Task<int> DeleteAsync(int reviewId);

        Task<List<ReviewViewModel>> GetByCakeIdAsync(int cakeId);

        Task<ReviewViewModel> GetByIdAsync(int reviewId);
    }
}