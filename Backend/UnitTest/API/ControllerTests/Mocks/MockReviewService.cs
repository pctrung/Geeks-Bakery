using GeeksBakery.Application.Interfaces;
using GeeksBakery.ViewModels.Common;
using GeeksBakery.ViewModels.Requests.Cake;
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
    public class MockReviewService : Mock<IReviewService>
    {
        public MockReviewService MockGetByCakeIdAsync(List<ReviewViewModel> result)
        {
            Setup(x => x.GetByCakeIdAsync(It.IsAny<int>())).ReturnsAsync(result);
            return this;
        }

        public MockReviewService MockGetByCakeIdAsync_ThrowException()
        {
            Setup(x => x.GetByCakeIdAsync(It.IsAny<int>())).Throws(new Exception());
            return this;
        }

        public MockReviewService MockGetByIdAsync(ReviewViewModel result)
        {
            Setup(x => x.GetByIdAsync(It.IsAny<int>(), It.IsAny<int>())).ReturnsAsync(result);
            return this;
        }

        public MockReviewService MockGetByIdAsync_ThrowException()
        {
            Setup(x => x.GetByIdAsync(It.IsAny<int>(), It.IsAny<int>())).Throws(new Exception());
            return this;
        }

        public MockReviewService MockCreateAsync(int result)
        {
            Setup(x => x.CreateAsync(It.IsAny<ReviewCreateRequest>())).ReturnsAsync(result);
            return this;
        }

        public MockReviewService MockCreateAsync_ThrowException()
        {
            Setup(x => x.CreateAsync(It.IsAny<ReviewCreateRequest>())).Throws(new Exception());
            return this;
        }

        public MockReviewService MockDeleteAsync(int result)
        {
            Setup(x => x.DeleteAsync(It.IsAny<int>(), It.IsAny<int>())).ReturnsAsync(result);
            return this;
        }

        public MockReviewService MockDeleteAsync_ThrowException()
        {
            Setup(x => x.DeleteAsync(It.IsAny<int>(), It.IsAny<int>())).Throws(new Exception());
            return this;
        }
    }
}