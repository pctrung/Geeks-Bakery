using GeeksBakery.BackendApi.Controllers;
using GeeksBakery.ViewModels.Catalog.CakeImage;
using GeeksBakery.ViewModels.Requests.CakeImage;
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
    public class ImagesControllerTest
    {
        // test for cake image api
        [Fact]
        public async void Get_ReturnsOk()
        {
            var mockData = new List<CakeImageViewModel>()
            {
             new CakeImageViewModel()
             {
                  CakeId = 1,
                   FileUrl = "",
             },
            };

            var mockCakeImageService = new MockCakeImageService().MockGetByCakeIdAsync(mockData);

            var controller = new ImagesController(mockCakeImageService.Object);

            OkObjectResult result = await controller.Get(1) as OkObjectResult;

            var content = JsonConvert.DeserializeObject<List<CakeImageViewModel>>(result.Value.ToString());

            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<List<CakeImageViewModel>>(content);
        }

        [Fact]
        public async void Get_ReturnsBadRequest()
        {
            var mockCakeImageService = new MockCakeImageService().MockGetByCakeIdAsync_ThrowException();

            var controller = new ImagesController(mockCakeImageService.Object);

            var result = await controller.Get(1);

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void GetById_ReturnsOk()
        {
            var mockData = new CakeImageViewModel()
            {
                CakeId = 1,
                FileUrl = ""
            };

            var mockCakeImageService = new MockCakeImageService().MockGetByIdAsync(mockData);

            var controller = new ImagesController(mockCakeImageService.Object);

            OkObjectResult result = await controller.GetById(1) as OkObjectResult;

            var content = JsonConvert.DeserializeObject<CakeImageViewModel>(result.Value.ToString());

            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<CakeImageViewModel>(content);
        }

        [Fact]
        public async void GetById_ReturnsBadRequest()
        {
            var mockCakeImageService = new MockCakeImageService().MockGetByIdAsync_ThrowException();

            var controller = new ImagesController(mockCakeImageService.Object);

            var result = await controller.GetById(1);

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void Create_WithValidModel_ReturnsOk()
        {
            var mockCakeImageService = new MockCakeImageService().MockCreateAsync(1).MockGetByIdAsync(new CakeImageViewModel());
            var controller = new ImagesController(mockCakeImageService.Object);

            var result = await controller.Create(new CakeImageCreateRequest()) as OkObjectResult;

            Assert.IsType<OkObjectResult>(result);

            var content = JsonConvert.DeserializeObject<CakeImageViewModel>(result.Value.ToString());
            Assert.IsType<CakeImageViewModel>(content);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void Create_WithValidModelAndCakeIdIsZero_ReturnsBadRequest()
        {
            var mockCakeImageService = new MockCakeImageService().MockCreateAsync(0);
            var controller = new ImagesController(mockCakeImageService.Object);

            var result = await controller.Create(new CakeImageCreateRequest());

            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async void Create_WithValidModelAndException_ReturnsBadRequest()
        {
            var mockCakeImageService = new MockCakeImageService().MockCreateAsync_ThrowException();
            var controller = new ImagesController(mockCakeImageService.Object);

            var result = await controller.Create(new CakeImageCreateRequest());

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void Create_WithInValidModel_ReturnsBadRequest()
        {
            var mockCakeImageService = new MockCakeImageService().MockCreateAsync(2);
            var controller = new ImagesController(mockCakeImageService.Object);
            controller.ModelState.AddModelError("Test", "Test");

            var result = await controller.Create(new CakeImageCreateRequest());

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void Create_WithGetByIdIsNull_ReturnsNotFound()
        {
            var mockCakeImageService = new MockCakeImageService().MockCreateAsync(2).MockGetByIdAsync(null);
            var controller = new ImagesController(mockCakeImageService.Object);

            var result = await controller.Create(new CakeImageCreateRequest());

            Assert.IsType<NotFoundObjectResult>(result);
        }

        [Fact]
        public async void Update_WithValidModel_ReturnsOk()
        {
            var mockCakeImageService = new MockCakeImageService().MockUpdateAsync(1).MockGetByIdAsync(new CakeImageViewModel());
            var controller = new ImagesController(mockCakeImageService.Object);

            var result = await controller.Update(new CakeImageUpdateRequest()) as OkObjectResult;

            Assert.IsType<OkObjectResult>(result);

            var content = JsonConvert.DeserializeObject<CakeImageViewModel>(result.Value.ToString());
            Assert.IsType<CakeImageViewModel>(content);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void Update_WithValidModelAndException_ReturnsBadRequest()
        {
            var mockCakeImageService = new MockCakeImageService().MockUpdateAsync_ThrowException();
            var controller = new ImagesController(mockCakeImageService.Object);

            var result = await controller.Update(new CakeImageUpdateRequest());

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void Update_WithInValidModel_ReturnsBadRequest()
        {
            var mockCakeImageService = new MockCakeImageService().MockUpdateAsync(2);
            var controller = new ImagesController(mockCakeImageService.Object);
            controller.ModelState.AddModelError("Test", "Test");

            var result = await controller.Update(new CakeImageUpdateRequest());

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void Update_WithGetByIdIsNull_ReturnsNotFound()
        {
            var mockCakeImageService = new MockCakeImageService().MockUpdateAsync(2).MockGetByIdAsync(null);
            var controller = new ImagesController(mockCakeImageService.Object);

            var result = await controller.Update(new CakeImageUpdateRequest());

            Assert.IsType<NotFoundObjectResult>(result);
        }

        [Fact]
        public async void Delete_ReturnsOk()
        {
            var mockCakeImageService = new MockCakeImageService().MockDeleteAsync(1);
            var controller = new ImagesController(mockCakeImageService.Object);

            var result = await controller.Delete(1);

            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void Delete_ReturnsBadRequest()
        {
            var mockCakeImageService = new MockCakeImageService().MockDeleteAsync_ThrowException();
            var controller = new ImagesController(mockCakeImageService.Object);

            var result = await controller.Delete(1);

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void Delete_ReturnsNotFound()
        {
            var mockCakeImageService = new MockCakeImageService().MockDeleteAsync(0);
            var controller = new ImagesController(mockCakeImageService.Object);

            var result = await controller.Delete(1);

            Assert.IsType<NotFoundObjectResult>(result);
        }
    }
}