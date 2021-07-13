using GeeksBakery.ViewModels.Requests.System.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeeksBakery.ClientSite.Controllers
{
    public class AccountsController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AccountsController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var b = ViewData["LoginRequest"];
            var a = ViewData["RegisterRequest"];
            return View();
        }

        public IActionResult Login([FromForm] LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                ViewData["LoginRequest"] = request;
                return View("Index");
            }

            return Ok();
        }

        public IActionResult Register([FromForm] RegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                ViewData["RegisterRequest"] = request;
                return View("Index");
            }
            return Ok();
        }
    }
}