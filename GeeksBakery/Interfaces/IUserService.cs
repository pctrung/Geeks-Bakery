using GeeksBakery.ViewModels.Common;
using GeeksBakery.ViewModels.Requests.System.Users;
using GeeksBakery.ViewModels.ViewModels;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace GeeksBakery.ClientSite.Interfaces
{
    public interface IUserService
    {
        Task<ApiResult<string>> AuthenticateAsync(LoginRequest request);

        Task<ApiResult<bool>> RegisterAsync(RegisterRequest request);

        Task<ApiResult<bool>> UpdateAsync(Guid id, UserUpdateRequest request);

        Task<ApiResult<UserViewModel>> GetByIdAsync(Guid id);

        Task<ApiResult<bool>> RoleAssignAsync(Guid id, RoleAssignRequest request);
    }
}