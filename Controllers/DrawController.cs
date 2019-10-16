using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using FestivalVar.Domain;
using FestivalVar.Domain.Utils.Responses;
using FestivalVar.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FestivalVar.Controllers
{    
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class DrawController : Controller
    {
        private readonly IDrawService _drawService;
        private readonly UserManager<ApplicationUser> _userManager;

        public DrawController(IDrawService drawService, UserManager<ApplicationUser> userManager)
        {
            _drawService = drawService;
            _userManager = userManager;
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

        [HttpPost("{DrawId}")]
        public async Task<IActionResult> UserJoinDraw([FromRoute] int DrawId)
        {
            ClaimsPrincipal currentUser = this.User;
            var currentUserName = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            ApplicationUser user = await _userManager.FindByNameAsync(currentUserName);

            var model = await _drawService.JoinDraw(user, DrawId);
            
            return Ok(new DrawResponse
            {
                Code = "success",
                Message = "draw.join.success",
            });
        }
        
    }
}