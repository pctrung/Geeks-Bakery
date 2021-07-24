using GeeksBakery.ClientSite.Interfaces;
using GeeksBakery.ViewModels.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GeeksBakery.ClientSite.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly IUserService _userService;

        public HeaderViewComponent(IUserService userService)
        {
            _userService = userService;
        }

        public IViewComponentResult Invoke()
        {
            UserViewModel header = new UserViewModel();
            if (User.Identity.IsAuthenticated)
            {
                var identity = (ClaimsIdentity)User.Identity;
                IEnumerable<Claim> claims = identity.Claims;

                header = _userService.ClaimsToViewModelAsync(claims);
            }
            else
            {
                header = null;
            }
            return View(header);
        }
    }
}