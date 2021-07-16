using GeeksBakery.ViewModels.Common;
using GeeksBakery.ViewModels.Requests.System.Users;
using GeeksBakery.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GeeksBakery.ClientSite.Interfaces
{
    public interface IUserService
    {
        Task<ApiResult<string>> AuthenticateAsync(LoginRequest request);

        Task<ApiResult<string>> RegisterAsync(RegisterRequest request);

        Task<ApiResult<bool>> UpdateAsync(Guid id, UserUpdateRequest request);

        Task<ApiResult<UserViewModel>> GetByIdAsync(Guid id);

        UserViewModel ClaimsToViewModelAsync(IEnumerable<Claim> claims);
    }
}