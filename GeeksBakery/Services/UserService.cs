using GeeksBakery.ClientSite.Interfaces;
using GeeksBakery.ViewModels.Common;
using GeeksBakery.ViewModels.Requests.System.Users;
using GeeksBakery.ViewModels.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.ClientSite.Services
{
    public class UserService : HttpServiceBase, IUserService
    {
        private readonly string _authenticateUri = "/api/users/authenticate";

        public UserService(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<ApiResult<string>> AuthenticateAsync(LoginRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await HttpPostAsync(_authenticateUri, httpContent);
            var result = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                return new ApiSuccessResult<string>(await response.Content.ReadAsStringAsync());
            }

            return new ApiErrorResult<string>(await response.Content.ReadAsStringAsync());
        }

        public async Task<ApiResult<UserViewModel>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResult<bool>> RegisterAsync(RegisterRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResult<bool>> RoleAssignAsync(Guid id, RoleAssignRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResult<bool>> UpdateAsync(Guid id, UserUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}