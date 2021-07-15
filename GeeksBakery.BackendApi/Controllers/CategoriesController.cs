using GeeksBakery.Application.Interfaces;
using GeeksBakery.ViewModels.Requests.Category;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace GeeksBakery.BackendApi.Controllers
{
    [Route("api/[controller]")]
    //    [Authorize]
    public class CategoriesController : ControllerBase
    {
        public readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var categories = await _categoryService.GetAllAsync();

                return Ok(JsonConvert.SerializeObject(categories));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{categoryId}")]
        public async Task<IActionResult> Get(int categoryId)
        {
            try
            {
                var categories = await _categoryService.GetByIdAsync(categoryId);

                return Ok(JsonConvert.SerializeObject(categories));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryCreateRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var categoryId = await _categoryService.CreateAsync(request);

                if (categoryId == 0)
                {
                    return BadRequest();
                }

                var data = await _categoryService.GetByIdAsync(categoryId);
                if (data == null)
                {
                    return NotFound($"Cannot find a cake with Id: {categoryId}");
                }
                return Ok(JsonConvert.SerializeObject(data));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(CategoryUpdateRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var result = await _categoryService.UpdateAsync(request);

                if (result == 0)
                {
                    return BadRequest();
                }

                var data = await _categoryService.GetByIdAsync(request.Id);
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

        [HttpDelete("{categoryId}")]
        public async Task<IActionResult> Delete(int categoryId)
        {
            try
            {
                var result = await _categoryService.DeleteAsync(categoryId);
                if (result == 0)
                {
                    return NotFound($"Cannot find a cake with Id: {categoryId}");
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