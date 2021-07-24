using GeeksBakery.ClientSite.Interfaces;
using GeeksBakery.ViewModels.Common;
using GeeksBakery.ViewModels.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace GeeksBakery.ClientSite.Services
{
    public class CategoryService : HttpServiceBase, ICategoryService
    {
        private readonly string _allCategoryUri = "/api/categories";

        public CategoryService(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<List<CategoryViewModel>> GetAllAsync()
        {
            HttpResponseMessage response = await this.HttpGetAsync(_allCategoryUri);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            return JsonConvert.DeserializeObject<List<CategoryViewModel>>(await response.Content.ReadAsStringAsync());
        }
    }
}