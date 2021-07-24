using GeeksBakery.Application.Interfaces;
using GeeksBakery.ViewModels.Requests.CakeImage;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace GeeksBakery.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly ICakeImageService _cakeImageService;

        public ImagesController(ICakeImageService cakeImageService)
        {
            _cakeImageService = cakeImageService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int cakeId)
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

        [HttpGet("{imageId}")]
        public async Task<IActionResult> GetById(int imageId, [FromQuery] int cakeId = 0)
        {
            try
            {
                var image = await _cakeImageService.GetByIdAsync(imageId, cakeId);

                return Ok(JsonConvert.SerializeObject(image));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Create([FromForm] CakeImageCreateRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var imageId = await _cakeImageService.CreateAsync(request);

                if (imageId == 0)
                {
                    return BadRequest();
                }

                var data = await _cakeImageService.GetByIdAsync(imageId, request.CakeId);
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

        [HttpPut]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Update([FromForm] CakeImageUpdateRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var result = await _cakeImageService.UpdateAsync(request, request.CakeId);
                 
                // pass parameter cakeId = 0 to don't check cake Id
                var data = await _cakeImageService.GetByIdAsync(request.Id, request.CakeId);
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

        [HttpDelete("{imageId}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Delete(int imageId, [FromQuery] int cakeId = 0)
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