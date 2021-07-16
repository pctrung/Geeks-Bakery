using GeeksBakery.ClientSite.Interfaces;
using GeeksBakery.ViewModels.Common;
using GeeksBakery.ViewModels.Requests.System.Users;
using GeeksBakery.ViewModels.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.ClientSite.Services
{
    public class UserService : HttpServiceBase, IUserService
    {
        private readonly string _authenticateUri = "/api/users/authenticate";
        private readonly string _getUserUri = "/api/users/authenticate";

        public UserService(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<ApiResult<string>> AuthenticateAsync(LoginRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await HttpPostAsync(_authenticateUri, httpContent);

            if (response.IsSuccessStatusCode)
            {
                return new ApiSuccessResult<string>(await response.Content.ReadAsStringAsync());
            }

            return new ApiErrorResult<string>(await response.Content.ReadAsStringAsync());
        }

        public UserViewModel ClaimsToViewModelAsync(IEnumerable<Claim> claims)
        {
            UserViewModel user = new UserViewModel();
            foreach (var claim in claims)
            {
                if (claim.Type == "DoB")
                {
                    CultureInfo culture = new CultureInfo("en-US");
                    DateTime date = Convert.ToDateTime(claim.Value, culture);

                    user.DoB = date;
                }
                else
                {
                    user.GetType().GetProperty(claim.Type.ToString())?.SetValue(user, claim.Value);
                }
            }
            return user;
        }

        public async Task<ApiResult<UserViewModel>> GetByIdAsync(Guid id)
        {
            var url = _getUserUri + "/" + id.ToString();

            HttpResponseMessage response = await HttpGetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                UserViewModel user = JsonConvert.DeserializeObject<UserViewModel>(await response.Content.ReadAsStringAsync());
                return new ApiSuccessResult<UserViewModel>(user);
            }

            return new ApiErrorResult<UserViewModel>(await response.Content.ReadAsStringAsync());
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