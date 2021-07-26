using GeeksBakery.Application.Interfaces;
using GeeksBakery.ViewModels.Common;
using GeeksBakery.ViewModels.Requests.Cake;
using GeeksBakery.ViewModels.Requests.Category;
using GeeksBakery.ViewModels.ViewModels;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.API.ControllerTests.Mocks
{
    public class MockCategoryService : Mock<ICategoryService>
    {
        public MockCategoryService MockGetAllAsync(List<CategoryViewModel> result)
        {
            Setup(x => x.GetAllAsync()).ReturnsAsync(result);

            return this;
        }

        public MockCategoryService MockGetAllPagingAsync_ThrowException()
        {
            Setup(x => x.GetAllAsync()).Throws(new Exception());

            return this;
        }

        public MockCategoryService MockCreateAsync(int result)
        {
            Setup(x => x.CreateAsync(It.IsAny<CategoryCreateRequest>())).ReturnsAsync(result);
            return this;
        }

        public MockCategoryService MockCreateAsync_ThrowException()
        {
            Setup(x => x.CreateAsync(It.IsAny<CategoryCreateRequest>())).Throws(new Exception());
            return this;
        }

        public MockCategoryService MockUpdateAsync(int result)
        {
            Setup(x => x.UpdateAsync(It.IsAny<CategoryUpdateRequest>())).ReturnsAsync(result);
            return this;
        }

        public MockCategoryService MockUpdateAsync_ThrowException()
        {
            Setup(x => x.UpdateAsync(It.IsAny<CategoryUpdateRequest>())).Throws(new Exception());
            return this;
        }

        public MockCategoryService MockDeleteAsync(int result)
        {
            Setup(x => x.DeleteAsync(It.IsAny<int>())).ReturnsAsync(result);
            return this;
        }

        public MockCategoryService MockDeleteAsync_ThrowException()
        {
            Setup(x => x.DeleteAsync(It.IsAny<int>())).Throws(new Exception());
            return this;
        }
    }
}