using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FestivalVar.Domain;
using FestivalVar.Domain.Utils.Requests;
using FestivalVar.Domain.Utils.Responses;
using FestivalVar.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FestivalVar.Controllers
{
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly UserManager<ApplicationUser> _userManager;

        public PostController(IPostService postService, UserManager<ApplicationUser> userManager)
        {
            _postService = postService;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var model = await _postService.GetAllPostsAsync();
            
            return Ok(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost([FromBody] CreatePostRequest request)
        {
            var user = this.GetUser();
            var post = new Post
            {
                Text = request.Text
            };

            await _postService.CreatePostAsync(post, await user);
            
            var response = new CreatePostResponse
            {
                Code = "success",
                Message = "create.post.success",
                Data = post
            };

            return Ok(response);
        }

        private async Task<ApplicationUser> GetUser()
        {
            ClaimsPrincipal currentUser = this.User;
            var currentUserName = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            ApplicationUser user = await _userManager.FindByNameAsync(currentUserName);

            return user;
        }
        
    }
}