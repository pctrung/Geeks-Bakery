using GeeksBakery.Application.Interfaces;
using GeeksBakery.Application.System.Users;
using GeeksBakery.ViewModels.Common;
using GeeksBakery.ViewModels.Requests.Cake;
using GeeksBakery.ViewModels.Requests.Category;
using GeeksBakery.ViewModels.Requests.System.Users;
using GeeksBakery.ViewModels.ViewModels;
using Microsoft.AspNetCore.Identity;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.API.ControllerTests.Mocks
{
    public class MockUserService : Mock<IUserService>
    {
        public MockUserService MockGetUsersPaging(ApiResult<PagedResult<UserViewModel>> result)
        {
            Setup(x => x.GetUsersPagingAsync(It.IsAny<GetUserPagingRequest>())).ReturnsAsync(result);

            return this;
        }

        public MockUserService MockGetByIdAsync(ApiResult<UserViewModel> result)
        {
            Setup(x => x.GetByIdAsync(It.IsAny<Guid>())).ReturnsAsync(result);

            return this;
        }

        public MockUserService MockAuthenticateAsync(string result)
        {
            Setup(x => x.AuthenticateAsync(It.IsAny<LoginRequest>())).ReturnsAsync(result);
            return this;
        }

        public MockUserService MockRegisterAsync(IdentityResult result)
        {
            Setup(x => x.RegisterAsync(It.IsAny<RegisterRequest>())).ReturnsAsync(result);
            return this;
        }

        public MockUserService MockRoleAssignAsync(ApiResult<bool> result)
        {
            Setup(x => x.RoleAssignAsync(It.IsAny<Guid>(), It.IsAny<RoleAssignRequest>())).ReturnsAsync(result);
            return this;
        }

        public MockUserService MockUpdateAsync(ApiResult<bool> result)
        {
            Setup(x => x.UpdateAsync(It.IsAny<UserUpdateRequest>())).ReturnsAsync(result);
            return this;
        }

        public MockUserService MockDeleteAsync(ApiResult<bool> result)
        {
            Setup(x => x.DeleteAsync(It.IsAny<Guid>())).ReturnsAsync(result);
            return this;
        }
    }
}