using GeeksBakery.Application.Interfaces;
using GeeksBakery.ViewModels.Requests.Cake;
using GeeksBakery.ViewModels.Requests.Review;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeeksBakery.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CakesController : ControllerBase
    {
        private readonly ICakeService _cakeService;
        public readonly IReviewService _reviewService;

        public CakesController(ICakeService cakeService, IReviewService reviewService)
        {
            _cakeService = cakeService;
            _reviewService = reviewService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetCakePagingRequest request)
        {
            try
            {
                var data = await _cakeService.GetAllPagingAsync(request);
                return Ok(JsonConvert.SerializeObject(data));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{cakeId}")]
        public async Task<IActionResult> Get(int cakeId)
        {
            try
            {
                var data = await _cakeService.GetByIdAsync(cakeId);
                if (data == null)
                {
                    return NotFound($"Cannot find a cake with Id: {cakeId}");
                }
                return Ok(JsonConvert.SerializeObject(data));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CakeCreateRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var cakeId = await _cakeService.CreateAsync(request);

                if (cakeId == 0)
                {
                    return BadRequest();
                }

                var data = await _cakeService.GetByIdAsync(cakeId);
                if (data == null)
                {
                    return NotFound($"Cannot find a cake with Id: {cakeId}");
                }
                return Ok(JsonConvert.SerializeObject(data));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromForm] CakeUpdateRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var result = await _cakeService.UpdateAsync(request);

                if (result == 0)
                {
                    return BadRequest();
                }

                var data = await _cakeService.GetByIdAsync(request.Id);
                if (data == null)
                {
                    return NotFound($"Cannot find a cake with Id: {request.Id}");
                }
                return Ok(JsonConvert.SerializeObject(data));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{cakeId}")]
        public async Task<IActionResult> Delete(int cakeId)
        {
            try
            {
                var result = await _cakeService.DeleteAsync(cakeId);
                if (result == 0)
                {
                    return NotFound($"Cannot find a cake with Id: {cakeId}");
                }

                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{cakeId}/reviews")]
        public async Task<IActionResult> GetReviews(int cakeId)
        {
            try
            {
                var reviews = await _reviewService.GetByCakeIdAsync(cakeId);

                return Ok(JsonConvert.SerializeObject(reviews));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{cakeId}/reviews/{reviewId}")]
        public async Task<IActionResult> GetReviewById(int reviewId)
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

        [HttpPost("{cakeId}/reviews")]
        public async Task<IActionResult> CreateReview([FromForm] ReviewCreateRequest request)
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

        [HttpDelete("{cakeId}/reviews/{reviewId}")]
        public async Task<IActionResult> DeleteReview(int reviewId)
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