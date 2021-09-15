using GeeksBakery.BackendApi.Controllers;
using GeeksBakery.ViewModels.Common;
using GeeksBakery.ViewModels.Requests.System.Users;
using GeeksBakery.ViewModels.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.API.ControllerTests.Mocks;
using Xunit;

namespace UnitTest.API.ControllerTests
{
    public class UsersControllerTest
    {
        private UserViewModel _testUserViewModel = new UserViewModel() { Address = "test", Id = "C39FC159-9040-4AF4-99AE-754B64076997" };
        private Guid _testGuid = new Guid("C39FC159-9040-4AF4-99AE-754B64076997");

        [Fact]
        public async void GetAllPaging_ReturnsOk()
        {
            var mockData = new ApiResult<PagedResult<UserViewModel>>() { IsSuccessed = true, ResultObj = new PagedResult<UserViewModel>() };

            var mockUserService = new MockUserService().MockGetUsersPaging(mockData);

            var controller = new UsersController(mockUserService.Object);

            OkObjectResult result = await controller.GetAllPaging(new GetUserPagingRequest()) as OkObjectResult;

            var content = result.Value;

            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<PagedResult<UserViewModel>>(content);
        }

        [Fact]
        public async void GetAllPaging_ReturnsBadRequest()
        {
            var mockData = new ApiResult<PagedResult<UserViewModel>>() { IsSuccessed = false, ResultObj = new PagedResult<UserViewModel>() };

            var mockUserService = new MockUserService().MockGetUsersPaging(mockData);

            var controller = new UsersController(mockUserService.Object);

            var result = await controller.GetAllPaging(new GetUserPagingRequest());

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void GetById_ReturnsOk()
        {
            var mockData = new ApiResult<UserViewModel>() { IsSuccessed = true, ResultObj = _testUserViewModel };

            var mockUserService = new MockUserService().MockGetByIdAsync(mockData);

            var controller = new UsersController(mockUserService.Object);

            OkObjectResult result = await controller.GetById(_testGuid) as OkObjectResult;

            var content = result.Value;

            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<UserViewModel>(content);
        }

        [Fact]
        public async void GetById_ReturnsBadRequest()
        {
            var mockData = new ApiResult<UserViewModel>() { IsSuccessed = false, ResultObj = _testUserViewModel };

            var mockUserService = new MockUserService().MockGetByIdAsync(mockData);

            var controller = new UsersController(mockUserService.Object);

            var result = await controller.GetById(new Guid("C39FC159-9040-4AF4-99AE-754B64076997"));

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void Register_WithValidModel_ReturnsOk()
        {
            var mockUserService = new MockUserService().MockRegisterAsync(IdentityResult.Success);
            var controller = new UsersController(mockUserService.Object);

            var result = await controller.Register(new RegisterRequest()) as OkObjectResult;

            Assert.IsType<OkObjectResult>(result);

            var content = result.Value;
            Assert.IsType<IdentityResult>(content);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void Register_WithValidModelAndRegisterUnsuccessful_ReturnsBadRequest()
        {
            var mockUserService = new MockUserService().MockRegisterAsync(IdentityResult.Failed(new IdentityError() { Description = "test" }));
            var controller = new UsersController(mockUserService.Object);

            var result = await controller.Register(new RegisterRequest());

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void Register_WithInValidModel_ReturnsBadRequest()
        {
            var mockData = new IdentityResult() { };
            var mockUserService = new MockUserService().MockRegisterAsync(mockData);
            var controller = new UsersController(mockUserService.Object);
            controller.ModelState.AddModelError("Test", "Test");

            var result = await controller.Register(new RegisterRequest());

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void Authenticate_WithValidModel_ReturnsOk()
        {
            var mockUserService = new MockUserService().MockAuthenticateAsync("test");
            var controller = new UsersController(mockUserService.Object);

            var result = await controller.Authenticate(new LoginRequest()) as OkObjectResult;

            Assert.IsType<OkObjectResult>(result);

            var content = result.Value;
            Assert.IsType<string>(content);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void Authenticate_WithValidModelAndNullToken_ReturnsBadRequest()
        {
            var mockUserService = new MockUserService().MockAuthenticateAsync(null);
            var controller = new UsersController(mockUserService.Object);

            var result = await controller.Authenticate(new LoginRequest());

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void Authenticate_WithInValidModel_ReturnsBadRequest()
        {
            var mockUserService = new MockUserService().MockAuthenticateAsync("Test");
            var controller = new UsersController(mockUserService.Object);
            controller.ModelState.AddModelError("Test", "Test");

            var result = await controller.Authenticate(new LoginRequest());

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void Update_WithValidModel_ReturnsOk()
        {
            var mockUserService = new MockUserService().MockUpdateAsync(new ApiResult<bool> { IsSuccessed = true });
            var controller = new UsersController(mockUserService.Object);

            var result = await controller.Update(new UserUpdateRequest()) as OkObjectResult;

            Assert.IsType<OkObjectResult>(result);

            var content = result.Value;
            Assert.IsType<ApiResult<bool>>(content);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void Update_WithValidModelAndUpdateUnsuccessful_ReturnsBadRequest()
        {
            var mockUserService = new MockUserService().MockUpdateAsync(new ApiResult<bool> { IsSuccessed = false });
            var controller = new UsersController(mockUserService.Object);

            var result = await controller.Update(new UserUpdateRequest());

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void Update_WithInValidModel_ReturnsBadRequest()
        {
            var mockUserService = new MockUserService().MockUpdateAsync(new ApiResult<bool> { IsSuccessed = true });
            var controller = new UsersController(mockUserService.Object);
            controller.ModelState.AddModelError("Test", "Test");

            var result = await controller.Update(new UserUpdateRequest());

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void RoleAssign_WithValidModel_ReturnsOk()
        {
            var mockUserService = new MockUserService().MockRoleAssignAsync(new ApiResult<bool> { IsSuccessed = true });
            var controller = new UsersController(mockUserService.Object);

            var result = await controller.RoleAssign(_testGuid, new RoleAssignRequest()) as OkObjectResult;

            Assert.IsType<OkObjectResult>(result);

            var content = result.Value;
            Assert.IsType<ApiResult<bool>>(content);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void RoleAssign_WithValidModelAndUpdateUnsuccessful_ReturnsBadRequest()
        {
            var mockUserService = new MockUserService().MockRoleAssignAsync(new ApiResult<bool> { IsSuccessed = false });
            var controller = new UsersController(mockUserService.Object);

            var result = await controller.RoleAssign(_testGuid, new RoleAssignRequest());

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void RoleAssign_WithInValidModel_ReturnsBadRequest()
        {
            var mockUserService = new MockUserService().MockRoleAssignAsync(new ApiResult<bool> { IsSuccessed = true });
            var controller = new UsersController(mockUserService.Object);
            controller.ModelState.AddModelError("Test", "Test");

            var result = await controller.RoleAssign(_testGuid, new RoleAssignRequest());

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void Delete_ReturnsOk()
        {
            var mockUserService = new MockUserService().MockDeleteAsync(new ApiResult<bool> { IsSuccessed = true });
            var controller = new UsersController(mockUserService.Object);

            var result = await controller.Delete(_testGuid);

            Assert.IsType<OkObjectResult>(result);
        }
    }
}