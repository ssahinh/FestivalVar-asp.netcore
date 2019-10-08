using System.Threading.Tasks;
using FestivalVar.Domain;
using FestivalVar.Requests;
using FestivalVar.Responses;
using FestivalVar.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FestivalVar.Controllers
{
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class FestivalController : Controller
    {
        private readonly IFestivalService _festivalService;

        public FestivalController(IFestivalService festivalService)
        {
            _festivalService = festivalService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var model = await _festivalService.GetFestivalsAsync();

            var response = new FestivalResponse
            {
                Code = "200",
                Message = "success",
                Data = model,
            };
            
            return Created("",response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFestival([FromBody] CreateFestivalRequest request)
        {
            var festival = new Festival
            {
                Title = request.Title,
                City = request.City,
            };

            await _festivalService.CreateFestivalAsync(festival);

            var response = new BaseResponse<Festival>()
            {
                Code = "200",
                Message = "success",
                Data = festival
            };

            return Created("",response);
        }
    }
}