using GeeksBakery.Application.Interfaces;
using GeeksBakery.ViewModels.Catalog.CakeImage;
using GeeksBakery.ViewModels.Common;
using GeeksBakery.ViewModels.Requests.Cake;
using GeeksBakery.ViewModels.Requests.CakeImage;
using GeeksBakery.ViewModels.Requests.Review;
using GeeksBakery.ViewModels.ViewModels;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.API.ControllerTests.Mocks
{
    public class MockCakeImageService : Mock<ICakeImageService>
    {
        public MockCakeImageService MockGetByCakeIdAsync(List<CakeImageViewModel> result)
        {
            Setup(x => x.GetByCakeIdAsync(It.IsAny<int>())).ReturnsAsync(result);
            return this;
        }

        public MockCakeImageService MockGetByCakeIdAsync_ThrowException()
        {
            Setup(x => x.GetByCakeIdAsync(It.IsAny<int>())).Throws(new Exception());
            return this;
        }

        public MockCakeImageService MockGetByIdAsync(CakeImageViewModel result)
        {
            Setup(x => x.GetByIdAsync(It.IsAny<int>(), It.IsAny<int>())).ReturnsAsync(result);
            return this;
        }

        public MockCakeImageService MockGetByIdAsync_ThrowException()
        {
            Setup(x => x.GetByIdAsync(It.IsAny<int>(), It.IsAny<int>())).Throws(new Exception());
            return this;
        }

        public MockCakeImageService MockCreateAsync(int result)
        {
            Setup(x => x.CreateAsync(It.IsAny<CakeImageCreateRequest>())).ReturnsAsync(result);
            return this;
        }

        public MockCakeImageService MockCreateAsync_ThrowException()
        {
            Setup(x => x.CreateAsync(It.IsAny<CakeImageCreateRequest>())).Throws(new Exception());
            return this;
        }

        public MockCakeImageService MockUpdateAsync(int result)
        {
            Setup(x => x.UpdateAsync(It.IsAny<CakeImageUpdateRequest>(), It.IsAny<int>())).ReturnsAsync(result);
            return this;
        }

        public MockCakeImageService MockUpdateAsync_ThrowException()
        {
            Setup(x => x.UpdateAsync(It.IsAny<CakeImageUpdateRequest>(), It.IsAny<int>())).Throws(new Exception());
            return this;
        }

        public MockCakeImageService MockDeleteAsync(int result)
        {
            Setup(x => x.DeleteAsync(It.IsAny<int>(), It.IsAny<int>())).ReturnsAsync(result);
            return this;
        }

        public MockCakeImageService MockDeleteAsync_ThrowException()
        {
            Setup(x => x.DeleteAsync(It.IsAny<int>(), It.IsAny<int>())).Throws(new Exception());
            return this;
        }
    }
}