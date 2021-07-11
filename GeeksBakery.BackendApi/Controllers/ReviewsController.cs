using GeeksBakery.Application.Interfaces;
using GeeksBakery.ViewModels.Requests.Category;
using GeeksBakery.ViewModels.Requests.Review;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace GeeksBakery.BackendApi.Controllers
{
    [Route("api/[controller]")]
    //    [Authorize]
    public class ReviewsController : ControllerBase
    {
        public readonly IReviewService _reviewService;

        public ReviewsController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpGet("{reviewId}")]
        public async Task<IActionResult> Get(int reviewId)
        {
            try
            {
                var review = await _reviewService.GetByIdAsync(reviewId);

                return Ok(JsonConvert.SerializeObject(review));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ReviewCreateRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var reviewId = await _reviewService.CreateAsync(request);

                if (reviewId == 0)
                {
                    return BadRequest();
                }

                var data = await _reviewService.GetByIdAsync(reviewId);
                if (data == null)
                {
                    return NotFound($"Cannot find a review with Id: {reviewId}");
                }
                return Ok(JsonConvert.SerializeObject(data));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{reviewId}")]
        public async Task<IActionResult> Delete(int reviewId)
        {
            try
            {
                var result = await _reviewService.DeleteAsync(reviewId);
                if (result == 0)
                {
                    return NotFound($"Cannot find a review with Id: {reviewId}");
                }

                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}