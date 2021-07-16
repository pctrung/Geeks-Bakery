using GeeksBakery.ViewModels.Requests.Review;
using System.Threading.Tasks;

namespace GeeksBakery.ClientSite.Interfaces
{
    public interface IReviewService
    {
        Task<bool> AddAsync(ReviewCreateRequest request);
    }
}