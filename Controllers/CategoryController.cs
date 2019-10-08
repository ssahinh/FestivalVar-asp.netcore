using System.Threading.Tasks;
using FestivalVar.Domain;
using FestivalVar.Responses;
using FestivalVar.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FestivalVar.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var model = await _categoryService.GetCategoriesAsync();

            var response = new CategoryResponse()
            {
                Code = "success",
                Message = "category.get.success",
                Data = model
            };

            return Created("", response);
        }
    }
}