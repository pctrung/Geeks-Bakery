using GeeksBakery.ViewModels.Requests.System.Users;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace GeeksBakery.Application.System.Users
{
    public interface IUserService
    {
        Task<string> AuthenticateAsync(LoginRequest request);

        Task<IdentityResult> RegisterAsync(RegisterRequest request);
    }
}