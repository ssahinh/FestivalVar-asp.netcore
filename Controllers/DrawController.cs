using System.Threading.Tasks;
using FestivalVar.Domain.Utils.Responses;
using FestivalVar.Services;
using Microsoft.AspNetCore.Mvc;

namespace FestivalVar.Controllers
{    
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class DrawController : Controller
    {
        private readonly IDrawService _drawService;

        public DrawController(IDrawService drawService)
        {
            _drawService = drawService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDraws()
        {
            var model = await _drawService.GetAllDraws();

            var response = new DrawResponse
            {
                Code = "success",
                Message = "draw.get.success",
                Data = model,
            };

            return Created("", response);
        }

        
    }
}