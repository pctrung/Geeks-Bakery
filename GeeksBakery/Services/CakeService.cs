using GeeksBakery.ClientSite.Interfaces;
using GeeksBakery.ViewModels.Common;
using GeeksBakery.ViewModels.Requests.Cake;
using GeeksBakery.ViewModels.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GeeksBakery.ClientSite.Services
{
    public class CakeService : HttpServiceBase, ICakeService
    {
        private readonly string _allCakeUri = "/api/cakes";

        public CakeService(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<List<CakeViewModel>> GetBestSellerCakesAsync()
        {
            var url = _allCakeUri;

            HttpResponseMessage response = await this.HttpGetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<List<CakeViewModel>>(await response.Content.ReadAsStringAsync());
        }

        public async Task<PagedResult<CakeViewModel>> GetPagingsAsync(GetCakePagingRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var url = _allCakeUri + $"?page={request.Page}&limit={request.Limit}&keyword={request.Keyword}&";
            url += request.CategoryIds != null ? $"{request.CategoryIds.Select(id => $"categoryids={id}&")}" : "";

            HttpResponseMessage response = await this.HttpGetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<PagedResult<CakeViewModel>>(await response.Content.ReadAsStringAsync());
        }
    }
}