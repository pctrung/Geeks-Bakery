using GeeksBakery.ClientSite.Interfaces;
using GeeksBakery.ClientSite.Models;
using GeeksBakery.ViewModels.Requests.Cake;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GeeksBakery.ClientSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICakeService _cakeService;
        private readonly ICategoryService _categoryService;

        public HomeController(ILogger<HomeController> logger, ICakeService cakeService, ICategoryService categoryService)
        {
            _logger = logger;
            _cakeService = cakeService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index([FromQuery] GetCakePagingRequest request)
        {
            request.Limit = 12;
            request.Page = request.Page > 0 ? request.Page : 1;
            request.Keyword = "";

            var cakes = await _cakeService.GetPagingsAsync(request);
            var categories = await _categoryService.GetAllAsync();

            var viewModel = new HomeViewModel()
            {
                Cakes = cakes,
                Categories = categories,
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}