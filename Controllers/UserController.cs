using System.Threading.Tasks;
using FestivalVar.Services;
using Microsoft.AspNetCore.Mvc;

namespace FestivalVar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetUsersAsync());
        }
    }
}