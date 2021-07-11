using GeeksBakery.Application.Interfaces;
using GeeksBakery.ViewModels.Requests.Category;
using GeeksBakery.ViewModels.Requests.Rate;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace GeeksBakery.BackendApi.Controllers
{
    [Route("api/[controller]")]
    //    [Authorize]
    public class RatesController : ControllerBase
    {
        public readonly IRateService _rateService;

        public RatesController(IRateService rateService)
        {
            _rateService = rateService;
        }

        [HttpGet("{cakeId}")]
        public async Task<IActionResult> Get(int cakeId)
        {
            try
            {
                var rates = await _rateService.GetByCakeIdAsync(cakeId);

                return Ok(JsonConvert.SerializeObject(rates));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] RateCreateRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var rateId = await _rateService.CreateAsync(request);

                if (rateId == 0)
                {
                    return BadRequest();
                }

                var data = await _rateService.GetByIdAsync(rateId);
                if (data == null)
                {
                    return NotFound($"Cannot find a rate with Id: {rateId}");
                }
                return Ok(JsonConvert.SerializeObject(data));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{rateId}")]
        public async Task<IActionResult> Delete(int rateId)
        {
            try
            {
                var result = await _rateService.DeleteAsync(rateId);
                if (result == 0)
                {
                    return NotFound($"Cannot find a rate with Id: {rateId}");
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