using GeeksBakery.BackendApi.Controllers;
using GeeksBakery.ViewModels.Requests.Category;
using GeeksBakery.ViewModels.ViewModels;
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
    public class CategoriesControllerTest
    {
        // test for cake image api
        [Fact]
        public async void Get_ReturnsOk()
        {
            var mockData = new List<CategoryViewModel>()
            {
             new CategoryViewModel()
             {
                  Id = 1,
             },
            };

            var mockCategoryService = new MockCategoryService().MockGetAllAsync(mockData);

            var controller = new CategoriesController(mockCategoryService.Object);

            OkObjectResult result = await controller.Get() as OkObjectResult;

            var content = JsonConvert.DeserializeObject<List<CategoryViewModel>>(result.Value.ToString());

            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<List<CategoryViewModel>>(content);
        }

        [Fact]
        public async void Get_ReturnsBadRequest()
        {
            var mockCategoryService = new MockCategoryService().MockGetAllAsync_ThrowException();

            var controller = new CategoriesController(mockCategoryService.Object);

            var result = await controller.Get();

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void GetById_ReturnsOk()
        {
            var mockData = new CategoryViewModel()
            {
                Id = 1,
            };

            var mockCategoryService = new MockCategoryService().MockGetByIdAsync(mockData);

            var controller = new CategoriesController(mockCategoryService.Object);

            OkObjectResult result = await controller.Get(1) as OkObjectResult;

            var content = JsonConvert.DeserializeObject<CategoryViewModel>(result.Value.ToString());

            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<CategoryViewModel>(content);
        }

        [Fact]
        public async void GetById_ReturnsBadRequest()
        {
            var mockCategoryService = new MockCategoryService().MockGetByIdAsync_ThrowException();

            var controller = new CategoriesController(mockCategoryService.Object);

            var result = await controller.Get(1);

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void Create_WithValidModel_ReturnsOk()
        {
            var mockCategoryService = new MockCategoryService().MockCreateAsync(1).MockGetByIdAsync(new CategoryViewModel());
            var controller = new CategoriesController(mockCategoryService.Object);

            var result = await controller.Create(new CategoryCreateRequest()) as OkObjectResult;

            Assert.IsType<OkObjectResult>(result);

            var content = JsonConvert.DeserializeObject<CategoryViewModel>(result.Value.ToString());
            Assert.IsType<CategoryViewModel>(content);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void Create_WithValidModelAndCakeIdIsZero_ReturnsBadRequest()
        {
            var mockCategoryService = new MockCategoryService().MockCreateAsync(0);
            var controller = new CategoriesController(mockCategoryService.Object);

            var result = await controller.Create(new CategoryCreateRequest());

            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async void Create_WithValidModelAndException_ReturnsBadRequest()
        {
            var mockCategoryService = new MockCategoryService().MockCreateAsync_ThrowException();
            var controller = new CategoriesController(mockCategoryService.Object);

            var result = await controller.Create(new CategoryCreateRequest());

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void Create_WithInValidModel_ReturnsBadRequest()
        {
            var mockCategoryService = new MockCategoryService().MockCreateAsync(2);
            var controller = new CategoriesController(mockCategoryService.Object);
            controller.ModelState.AddModelError("Test", "Test");

            var result = await controller.Create(new CategoryCreateRequest());

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void Create_WithGetByIdIsNull_ReturnsNotFound()
        {
            var mockCategoryService = new MockCategoryService().MockCreateAsync(2).MockGetByIdAsync(null);
            var controller = new CategoriesController(mockCategoryService.Object);

            var result = await controller.Create(new CategoryCreateRequest());

            Assert.IsType<NotFoundObjectResult>(result);
        }

        [Fact]
        public async void Update_WithValidModel_ReturnsOk()
        {
            var mockCategoryService = new MockCategoryService().MockUpdateAsync(1).MockGetByIdAsync(new CategoryViewModel());
            var controller = new CategoriesController(mockCategoryService.Object);

            var result = await controller.Update(new CategoryUpdateRequest()) as OkObjectResult;

            Assert.IsType<OkObjectResult>(result);

            var content = JsonConvert.DeserializeObject<CategoryViewModel>(result.Value.ToString());
            Assert.IsType<CategoryViewModel>(content);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void Update_WithValidModelAndException_ReturnsBadRequest()
        {
            var mockCategoryService = new MockCategoryService().MockUpdateAsync_ThrowException();
            var controller = new CategoriesController(mockCategoryService.Object);

            var result = await controller.Update(new CategoryUpdateRequest());

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void Update_WithInValidModel_ReturnsBadRequest()
        {
            var mockCategoryService = new MockCategoryService().MockUpdateAsync(2);
            var controller = new CategoriesController(mockCategoryService.Object);
            controller.ModelState.AddModelError("Test", "Test");

            var result = await controller.Update(new CategoryUpdateRequest());

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void Update_WithGetByIdIsNull_ReturnsNotFound()
        {
            var mockCategoryService = new MockCategoryService().MockUpdateAsync(2).MockGetByIdAsync(null);
            var controller = new CategoriesController(mockCategoryService.Object);

            var result = await controller.Update(new CategoryUpdateRequest());

            Assert.IsType<NotFoundObjectResult>(result);
        }

        [Fact]
        public async void Delete_ReturnsOk()
        {
            var mockCategoryService = new MockCategoryService().MockDeleteAsync(1);
            var controller = new CategoriesController(mockCategoryService.Object);

            var result = await controller.Delete(1);

            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void Delete_ReturnsBadRequest()
        {
            var mockCategoryService = new MockCategoryService().MockDeleteAsync_ThrowException();
            var controller = new CategoriesController(mockCategoryService.Object);

            var result = await controller.Delete(1);

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void Delete_ReturnsNotFound()
        {
            var mockCategoryService = new MockCategoryService().MockDeleteAsync(0);
            var controller = new CategoriesController(mockCategoryService.Object);

            var result = await controller.Delete(1);

            Assert.IsType<NotFoundObjectResult>(result);
        }
    }
}