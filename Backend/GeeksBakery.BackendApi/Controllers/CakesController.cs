using GeeksBakery.Application.Interfaces;
using GeeksBakery.ViewModels.Requests.Cake;
using GeeksBakery.ViewModels.Requests.CakeImage;
using GeeksBakery.ViewModels.Requests.Review;
using Microsoft.AspNetCore.Authorization;
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
        private readonly ICakeImageService _cakeImageService;

        public CakesController(ICakeService cakeService, IReviewService reviewService, ICakeImageService cakeImageService)
        {
            _cakeService = cakeService;
            _reviewService = reviewService;
            _cakeImageService = cakeImageService;
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

        [HttpGet("bestSeller/{take?}")]
        public async Task<IActionResult> GetBestSellerCakes(int take = 5)
        {
            try
            {
                var data = await _cakeService.GetBestSellerCakesAsync(take);

                return Ok(JsonConvert.SerializeObject(data));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Create([FromBody] CakeCreateRequest request)
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
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Update([FromBody] CakeUpdateRequest request)
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
        [Authorize(Roles = "admin")]
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
        public async Task<IActionResult> GetReviewById(int reviewId, int cakeId)
        {
            try
            {
                var review = await _reviewService.GetByIdAsync(reviewId, cakeId);

                return Ok(JsonConvert.SerializeObject(review));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("{cakeId}/reviews")]
        [Authorize]
        public async Task<IActionResult> CreateReview([FromBody] ReviewCreateRequest request, [FromRoute] int cakeId)
        {
            try
            {
                if (request.CakeId != cakeId)
                {
                    return BadRequest("Cake Id in both request and query must be the same");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var reviewId = await _reviewService.CreateAsync(request);

                if (reviewId == 0)
                {
                    return BadRequest();
                }

                var data = await _reviewService.GetByIdAsync(reviewId, cakeId);
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
        [Authorize]
        public async Task<IActionResult> DeleteReview(int reviewId, int cakeId)
        {
            try
            {
                var result = await _reviewService.DeleteAsync(reviewId, cakeId);
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

        [HttpGet("{cakeId}/images")]
        public async Task<IActionResult> GetImagesByCakeId(int cakeId)
        {
            try
            {
                var images = await _cakeImageService.GetByCakeIdAsync(cakeId);

                return Ok(JsonConvert.SerializeObject(images));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{cakeId}/images/{imageId}")]
        public async Task<IActionResult> GetImageById(int imageId, int cakeId)
        {
            try
            {
                var image = await _cakeImageService.GetByIdAsync(imageId, cakeId);

                if (image == null)
                {
                    return NotFound($"Cannot find image with Id: {imageId}");
                }

                return Ok(JsonConvert.SerializeObject(image));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("{cakeId}/images")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> CreateImage([FromForm] CakeImageCreateRequest request, int cakeId)
        {
            try
            {
                if (request.CakeId != cakeId)
                {
                    return BadRequest("Cake Id in request and query must be the same");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var imageId = await _cakeImageService.CreateAsync(request);

                if (imageId == 0)
                {
                    return BadRequest();
                }

                var data = await _cakeImageService.GetByIdAsync(imageId, cakeId);
                if (data == null)
                {
                    return NotFound($"Cannot find image with Id: {imageId}");
                }
                return Ok(JsonConvert.SerializeObject(data));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{cakeId}/images")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> UpdateImage([FromForm] CakeImageUpdateRequest request, int cakeId = 0)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var result = await _cakeImageService.UpdateAsync(request, cakeId);

                if (result == 0)
                {
                    return BadRequest();
                }

                var data = await _cakeImageService.GetByIdAsync(request.Id, cakeId);
                if (data == null)
                {
                    return NotFound($"Cannot find image with Id: {request.Id}");
                }
                return Ok(JsonConvert.SerializeObject(data));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{cakeId}/images/{imageId}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> DeleteImage(int imageId, int cakeId)
        {
            try
            {
                var result = await _cakeImageService.DeleteAsync(imageId, cakeId);
                if (result == 0)
                {
                    return NotFound($"Cannot find image with Id: {imageId}");
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