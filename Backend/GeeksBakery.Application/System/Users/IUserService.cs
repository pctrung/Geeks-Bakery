using GeeksBakery.ViewModels.Common;
using GeeksBakery.ViewModels.Requests.System.Users;
using GeeksBakery.ViewModels.ViewModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace GeeksBakery.Application.System.Users
{
    public interface IUserService
    {
        Task<string> AuthenticateAsync(LoginRequest request);

        Task<IdentityResult> RegisterAsync(RegisterRequest request);

        Task<ApiResult<bool>> UpdateAsync(UserUpdateRequest request);

        Task<ApiResult<PagedResult<UserViewModel>>> GetUsersPagingAsync(GetUserPagingRequest request);

        Task<ApiResult<UserViewModel>> GetByIdAsync(Guid id);

        Task<ApiResult<bool>> DeleteAsync(Guid id);

        Task<ApiResult<bool>> RoleAssignAsync(Guid id, RoleAssignRequest request);
    }
}