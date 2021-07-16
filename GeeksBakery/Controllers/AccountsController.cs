using GeeksBakery.ClientSite.Interfaces;
using GeeksBakery.Utilities.SystemConstants;
using GeeksBakery.ViewModels.Requests.System.Users;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.ClientSite.Controllers
{
    public class AccountsController : Controller
    {
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;

        public AccountsController(IUserService userService, IConfiguration configuration)
        {
            _userService = userService;
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            if (TempData["IsRegisterSuccess"] != null)
            {
                ViewBag.IsRegisterSuccess = true;
                TempData["IsRegisterSuccess"] = null;
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            ViewBag.IsLogin = true;
            if (!ModelState.IsValid)
            {
                ViewData["LoginRequest"] = request;
                return View("Index");
            }

            var response = await _userService.AuthenticateAsync(request);

            // return error to login view if login unsuccessul
            if (!response.IsSuccessed)
            {
                ModelState.AddModelError("", "Username or password is incorrect");
                ViewData["LoginRequest"] = request;

                return View("Index");
            }

            //Add token and session
            var userPrincipal = this.ValidateToken(response.ResultObj);

            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                IsPersistent = false
            };
            HttpContext.Session.SetString(SystemConstants.AppSettings.Token, response.ResultObj);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userPrincipal, authProperties);

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            ViewBag.IsLogin = false;

            if (!ModelState.IsValid)
            {
                ViewData["RegisterRequest"] = request;
                return View("Index");
            }
            var result = await _userService.RegisterAsync(request);
            if (!result.IsSuccessed)
            {
                ModelState.AddModelError("", result.Message);
                ViewData["RegisterRequest"] = request;
                return View("Index");
            }
            TempData["IsRegisterSuccess"] = true;

            return RedirectToAction("Index", "Accounts");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

        private ClaimsPrincipal ValidateToken(string jwtToken)
        {
            IdentityModelEventSource.ShowPII = true;

            SecurityToken validatedToken;
            TokenValidationParameters validationParameters = new TokenValidationParameters();

            validationParameters.ValidateLifetime = true;

            validationParameters.ValidAudience = _configuration["Tokens:Issuer"];
            validationParameters.ValidIssuer = _configuration["Tokens:Issuer"];
            validationParameters.IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));

            ClaimsPrincipal principal = new JwtSecurityTokenHandler().ValidateToken(jwtToken, validationParameters, out validatedToken);

            return principal;
        }
    }
}