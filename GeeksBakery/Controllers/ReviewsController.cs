using GeeksBakery.ClientSite.Interfaces;
using GeeksBakery.ViewModels.Requests.Review;
using GeeksBakery.ViewModels.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GeeksBakery.ClientSite.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly IUserService _userService;
        private readonly IReviewService _reviewService;

        public ReviewsController(IUserService userService, IReviewService reviewService)
        {
            _userService = userService;
            _reviewService = reviewService;
        }

        [HttpPost("{cakeId}")]
        public async Task<IActionResult> Add(int cakeId, string returnUrl, ReviewCreateRequest request)
        {
            returnUrl = returnUrl == null ? "" : returnUrl;
            UserViewModel user = new UserViewModel();
            if (User.Identity.IsAuthenticated)
            {
                var identity = (ClaimsIdentity)User.Identity;
                IEnumerable<Claim> claims = identity.Claims;

                user = _userService.ClaimsToViewModelAsync(claims);

                request.UserId = user.Id;

                var isAddSuccess = await _reviewService.AddAsync(request);
            }
            return Redirect(returnUrl);
        }
    }
}