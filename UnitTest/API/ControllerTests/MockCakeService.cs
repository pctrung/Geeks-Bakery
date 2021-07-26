using GeeksBakery.Application.Interfaces;
using GeeksBakery.ViewModels.Common;
using GeeksBakery.ViewModels.Requests.Cake;
using GeeksBakery.ViewModels.ViewModels;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.API.ControllerTests
{
    public class MockCakeService : Mock<ICakeService>
    {
        private Mock<ICakeService> mockCakeService = new Mock<ICakeService>();

        public MockCakeService MockGetAllPagingAsync(PagedResult<CakeViewModel> result)
        {
            Setup(x => x.GetAllPagingAsync(It.IsAny<GetCakePagingRequest>())).ReturnsAsync(result);

            return this;
        }

        public MockCakeService MockGetAllPagingAsync_ThrowException()
        {
            Setup(x => x.GetAllPagingAsync(It.IsAny<GetCakePagingRequest>())).Throws(new Exception());

            return this;
        }

        public MockCakeService MockGetBestSellerAsync(List<CakeViewModel> result)
        {
            Setup(x => x.GetBestSellerCakesAsync(It.IsAny<int>())).ReturnsAsync(result);
            return this;
        }

        public MockCakeService MockGetBestSellerAsync_ThrowException()
        {
            Setup(x => x.GetBestSellerCakesAsync(It.IsAny<int>())).Throws(new Exception());
            return this;
        }

        public MockCakeService MockGetByIdAsync(CakeViewModel result)
        {
            Setup(x => x.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(result);
            return this;
        }

        public MockCakeService MockGetByIdAsync_ThrowException()
        {
            Setup(x => x.GetByIdAsync(It.IsAny<int>())).Throws(new Exception());
            return this;
        }

        public MockCakeService MockCreateAsync(int result)
        {
            Setup(x => x.CreateAsync(It.IsAny<CakeCreateRequest>())).ReturnsAsync(result);
            return this;
        }

        public MockCakeService MockCreateAsync_ThrowException()
        {
            Setup(x => x.CreateAsync(It.IsAny<CakeCreateRequest>())).Throws(new Exception());
            return this;
        }

        public MockCakeService MockUpdateAsync(int result)
        {
            Setup(x => x.UpdateAsync(It.IsAny<CakeUpdateRequest>())).ReturnsAsync(result);
            return this;
        }

        public MockCakeService MockUpdateAsync_ThrowException()
        {
            Setup(x => x.UpdateAsync(It.IsAny<CakeUpdateRequest>())).Throws(new Exception());
            return this;
        }

        public MockCakeService MockDeleteAsync(int result)
        {
            Setup(x => x.DeleteAsync(It.IsAny<int>())).ReturnsAsync(result);
            return this;
        }

        public MockCakeService MockDeleteAsync_ThrowException()
        {
            Setup(x => x.DeleteAsync(It.IsAny<int>())).Throws(new Exception());
            return this;
        }
    }
}