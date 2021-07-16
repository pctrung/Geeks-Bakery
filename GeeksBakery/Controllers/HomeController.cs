using GeeksBakery.ClientSite.Interfaces;
using GeeksBakery.ClientSite.Models;
using GeeksBakery.ViewModels.Requests.Cake;
using GeeksBakery.ViewModels.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GeeksBakery.ClientSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICakeService _cakeService;
        private readonly ICategoryService _categoryService;
        private readonly IUserService _userService;

        public HomeController(ILogger<HomeController> logger, ICakeService cakeService, ICategoryService categoryService, IUserService userService)
        {
            _logger = logger;
            _cakeService = cakeService;
            _categoryService = categoryService;
            _userService = userService;
        }

        public async Task<IActionResult> Index([FromQuery] GetCakePagingRequest request)
        {
            request.Limit = 12;
            request.Page = request.Page > 0 ? request.Page : 1;
            request.Keyword = "";

            var cakes = await _cakeService.GetPagingsAsync(request);
            var bestseller = await _cakeService.GetBestSellerCakesAsync(5);
            var categories = await _categoryService.GetAllAsync();

            var viewModel = new HomeViewModel()
            {
                Cakes = cakes,
                Categories = categories,
                FeaturedCakes = bestseller
            };

            if (User.Identity.IsAuthenticated)
            {
                var identity = (ClaimsIdentity)User.Identity;
                IEnumerable<Claim> claims = identity.Claims;

                UserViewModel user = _userService.ClaimsToViewModelAsync(claims);

                viewModel.User = user;
            }

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