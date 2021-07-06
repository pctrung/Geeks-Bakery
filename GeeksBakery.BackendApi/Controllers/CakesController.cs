using GeeksBakery.Application.Catalog.Cakes;
using GeeksBakery.ViewModels.Catalog.Cakes.Dtos;
using GeeksBakery.ViewModels.Catalog.Dtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace GeeksBakery.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CakesController : ControllerBase
    {
        private readonly ICakeService _cakeService;
        public CakesController(ICakeService cakeService)
        {
            _cakeService = cakeService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetCakePagingRequest request)
        {

            try
            {
                var data = await _cakeService.GetAllPaging(request);
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
                var data = await _cakeService.GetById(cakeId);
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

                var cakeId = await _cakeService.Create(request);

                if (cakeId == 0)
                {
                    return BadRequest();
                }

                var data = await _cakeService.GetById(cakeId);
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

                var result = await _cakeService.Update(request);

                if (result == 0)
                {
                    return BadRequest();
                }

                var data = await _cakeService.GetById(request.Id);
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
                var result = await _cakeService.Delete(cakeId);
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
    }
}
