using GeeksBakery.Application.Interfaces;
using GeeksBakery.BackendApi.Controllers;
using GeeksBakery.ViewModels.Common;
using GeeksBakery.ViewModels.Requests.Cake;
using GeeksBakery.ViewModels.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTest.API.ControllerTests
{
    public class CakesControllerTest
    {
        #region Property

        public Mock<ICakeService> _mockCakeService = new Mock<ICakeService>();
        public Mock<IReviewService> _mockReviewService = new Mock<IReviewService>();
        public Mock<ICakeImageService> _mockCakeImageService = new Mock<ICakeImageService>();

        #endregion Property

        [Fact]
        public async void Get_ReturnsOk()
        {
            var mockData = new PagedResult<CakeViewModel>()
            {
                Items = new List<CakeViewModel>()
                {
                    new CakeViewModel()
             {
                 Id = 1,
                 Name = "Blackforest Cake With Cherries",
                 Description = "We kept this Classic cake untouched and unblemished because we feel it's perfect as it is. Baked with the richness of cocoa and lusciousness of fresh vanilla cream, topped with soft chocolate shavings and fresh cherries, this delicious cake will make you surrender to the zest forces of Sweet Indulgence. Savour the original taste of the all time classic- The Black Forest.",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 4,
                 Price = 150000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 200000
             },
             new CakeViewModel()
             {
                 Id = 2,
                 Name = "Snicker Fuse Chocolate Cake",
                 Description = "Award yourself with this rich chocolate cake wonderfully crammed with Cadbury Fuse and white chocolate chunks and draped lusciously with molten chocolate.This perfect work of art hides in every bite, the scrumptious flavours of heavily whipped chocolate cream and nutty bits of chocolate that is a little nutty and a lot of tasty! ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 1,
                 Price = 200000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 250000
             },
             new CakeViewModel()
             {
                 Id = 3,
                 Name = "Red Velvet Fruit Layer Cake",
                 Description = "An exceptionally creamy Open - layered Red Velvet cake with a topping that tastes like a MASH UP between the tropical fruits is truly a luxurious treat.Experience the richness and smoothness in this delicacy which is laden with kiwis, cherries,apples, dragon fruits and black grapes.Who said healthy and delicious are poles apart ?",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 2,
                 Price = 180000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 260000
             },
             new CakeViewModel()
             {
                 Id = 4,
                 Name = "Chocolaty Creamy Round Cake",
                 Description = "This round chocolaty cake is the perfect treat for someone who is absolutely in love with chocolate cakes.This cake covered in rich chocolate ganache and decorated with chocolate shavings is the best gift one can have on their special day. ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 1,
                 Price = 290000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 310000
             },
             new CakeViewModel()
             {
                 Id = 5,
                 Name = "Rainbow Sprinkles Cake",
                 Description = "Any celebration is incomplete without this funfetti cake. Pipped with beautiful creamy decorations, this towering beauty is a grandiose deliciousness is sure to sweep everyone off their feet.And not just this, along with this beautify their day with extra sweetness and some extra colors with each bite topped with sumptuous confetti. ",
                 Stock = 1,
                 Size = 20,
                 CategoryId = 6,
                 Price = 350000,
                 DateCreated = DateTime.Now,
                 OriginalPrice = 400000
             },
                },
                Keyword = "",
                Limit = 10,
                Page = 1,
            };

            var mockCakeService = new MockCakeService().MockGetAllPagingAsync(mockData);

            var controller = new CakesController(mockCakeService.Object, _mockReviewService.Object, _mockCakeImageService.Object);

            OkObjectResult result = await controller.Get(new GetCakePagingRequest() { }) as OkObjectResult;

            var content = JsonConvert.DeserializeObject<PagedResult<CakeViewModel>>(result.Value.ToString());

            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<PagedResult<CakeViewModel>>(content);
            Assert.Equal(5, content.Items.Count);
        }

        [Fact]
        public async void Get_ReturnsBadRequest()
        {
            var mockCakeService = new MockCakeService().MockGetAllPagingAsync_ThrowException();

            var controller = new CakesController(mockCakeService.Object, _mockReviewService.Object, _mockCakeImageService.Object);

            var result = await controller.Get(new GetCakePagingRequest() { });

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void GetById_ReturnsOk()
        {
            var mockData = new CakeViewModel()
            {
                Id = 1,
                Name = "Blackforest Cake With Cherries",
                Description = "We kept this Classic cake untouched and unblemished because we feel it's perfect as it is. Baked with the richness of cocoa and lusciousness of fresh vanilla cream, topped with soft chocolate shavings and fresh cherries, this delicious cake will make you surrender to the zest forces of Sweet Indulgence. Savour the original taste of the all time classic- The Black Forest.",
                Stock = 1,
                Size = 20,
                CategoryId = 4,
                Price = 150000,
                DateCreated = DateTime.Now,
                OriginalPrice = 200000
            };

            var mockCakeService = new MockCakeService().MockGetByIdAsync(mockData);

            var controller = new CakesController(mockCakeService.Object, _mockReviewService.Object, _mockCakeImageService.Object);

            OkObjectResult result = await controller.Get(1) as OkObjectResult;

            var content = JsonConvert.DeserializeObject<CakeViewModel>(result.Value.ToString());

            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<CakeViewModel>(content);
        }

        [Fact]
        public async void GetById_ReturnsBadRequest()
        {
            var mockCakeService = new MockCakeService().MockGetByIdAsync_ThrowException();

            var controller = new CakesController(mockCakeService.Object, _mockReviewService.Object, _mockCakeImageService.Object);

            var result = await controller.Get(1);

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void GetById_ReturnsNotFound()
        {
            var mockCakeService = new MockCakeService().MockGetByIdAsync(null);

            var controller = new CakesController(mockCakeService.Object, _mockReviewService.Object, _mockCakeImageService.Object);

            var result = await controller.Get(1);

            Assert.IsType<NotFoundObjectResult>(result);
        }

        [Fact]
        public async void GetBestSeller_ReturnsOk()
        {
            var mockData = new List<CakeViewModel>()
            {
                new CakeViewModel()
                {
                    Id = 1,
                    Name = "Blackforest Cake With Cherries",
                    Description = "We kept this Classic cake untouched and unblemished because we feel it's perfect as it is. Baked with the richness of cocoa and lusciousness of fresh vanilla cream, topped with soft chocolate shavings and fresh cherries, this delicious cake will make you surrender to the zest forces of Sweet Indulgence. Savour the original taste of the all time classic- The Black Forest.",
                    Stock = 1,
                    Size = 20,
                    CategoryId = 4,
                    Price = 150000,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 200000
                }
            };

            var mockCakeService = new MockCakeService().MockGetBestSellerAsync(mockData);

            var controller = new CakesController(mockCakeService.Object, _mockReviewService.Object, _mockCakeImageService.Object);

            OkObjectResult result = await controller.GetBestSellerCakes(1) as OkObjectResult;

            var content = JsonConvert.DeserializeObject<List<CakeViewModel>>(result.Value.ToString());

            Assert.IsType<OkObjectResult>(result);
            Assert.IsType<List<CakeViewModel>>(content);
        }

        [Fact]
        public async void GetBestSeller_ReturnsBadRequest()
        {
            var mockCakeService = new MockCakeService().MockGetBestSellerAsync_ThrowException();

            var controller = new CakesController(mockCakeService.Object, _mockReviewService.Object, _mockCakeImageService.Object);

            var result = await controller.GetBestSellerCakes(1);

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void Create_WithValidModel_ReturnsOk()
        {
            var mockCakeService = new MockCakeService().MockCreateAsync(1).MockGetByIdAsync(new CakeViewModel());
            var controller = new CakesController(mockCakeService.Object, _mockReviewService.Object, _mockCakeImageService.Object);

            var result = await controller.Create(new CakeCreateRequest()) as OkObjectResult;

            Assert.IsType<OkObjectResult>(result);

            var content = JsonConvert.DeserializeObject<CakeViewModel>(result.Value.ToString());
            Assert.IsType<CakeViewModel>(content);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async void Create_WithValidModelAndCakeIdIsZero_ReturnsBadRequest()
        {
            var mockCakeService = new MockCakeService().MockCreateAsync(0);
            var controller = new CakesController(mockCakeService.Object, _mockReviewService.Object, _mockCakeImageService.Object);

            var result = await controller.Create(new CakeCreateRequest());

            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async void Create_WithValidModelAndException_ReturnsBadRequest()
        {
            var mockCakeService = new MockCakeService().MockCreateAsync_ThrowException();
            var controller = new CakesController(mockCakeService.Object, _mockReviewService.Object, _mockCakeImageService.Object);

            var result = await controller.Create(new CakeCreateRequest());

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void Create_WithInValidModel_ReturnsBadRequest()
        {
            var mockCakeService = new MockCakeService().MockCreateAsync(2);
            var controller = new CakesController(mockCakeService.Object, _mockReviewService.Object, _mockCakeImageService.Object);
            controller.ModelState.AddModelError("Test", "Test");

            var result = await controller.Create(new CakeCreateRequest());

            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async void Create_WithGetByIdIsNull_ReturnsNotFound()
        {
            var mockCakeService = new MockCakeService().MockCreateAsync(2).MockGetByIdAsync(null);
            var controller = new CakesController(mockCakeService.Object, _mockReviewService.Object, _mockCakeImageService.Object);

            var result = await controller.Create(new CakeCreateRequest());

            Assert.IsType<NotFoundObjectResult>(result);
        }
    }
}