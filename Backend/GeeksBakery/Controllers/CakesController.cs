using GeeksBakery.ClientSite.Interfaces;
using GeeksBakery.ClientSite.Models;
using GeeksBakery.ViewModels.Requests.Cake;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeeksBakery.ClientSite.Controllers
{
    public class CakesController : Controller
    {
        private readonly ICakeService _cakeService;
        private readonly ICategoryService _categoryService;

        public CakesController(ICakeService cakeService, ICategoryService categoryService)
        {
            _cakeService = cakeService;
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Index([FromQuery] GetCakePagingRequest request)
        {
            request.Limit = 12;
            request.Page = request.Page > 0 ? request.Page : 1;

            var cakes = await _cakeService.GetPagingsAsync(request);
            var categories = await _categoryService.GetAllAsync();

            var viewModel = new CakesViewModel()
            {
                Cakes = cakes,
                Categories = categories
            };

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var cakes = await _cakeService.GetByIdAsync(id);

            return View(cakes);
        }
    }
}