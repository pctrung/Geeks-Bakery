using GeeksBakery.ClientSite.Interfaces;
using GeeksBakery.ViewModels.Requests.Review;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.ClientSite.Services
{
    public class ReviewService : HttpServiceBase, IReviewService
    {
        private readonly string _addReviewUri = "/api/cakes";

        public ReviewService(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<bool> AddAsync(ReviewCreateRequest request)
        {
            var url = _addReviewUri + "/" + request.CakeId + "/reviews";

            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await HttpPostAsync(url, httpContent);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }
    }
}