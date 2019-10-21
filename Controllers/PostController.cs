using System.Threading.Tasks;
using FestivalVar.Domain.Utils.Responses;
using FestivalVar.Services;
using Microsoft.AspNetCore.Mvc;

namespace FestivalVar.Controllers
{
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : Controller
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var model = await _postService.GetAllPostsAsync();

            var response = new PostResponse
            {
                Code = "success",
                Message = "posts.getall.success",
                Data = model
            };

            return Created("", response);
        }
        
    }
}