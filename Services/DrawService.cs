using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FestivalVar.Data;
using FestivalVar.Domain;
using FestivalVar.Domain.Utils.Responses;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FestivalVar.Services
{
    public class DrawService : IDrawService
    {
        private readonly DataContext _context;

        public DrawService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Draw>> GetAllDraws()
        {
            return await _context.Draws.ToListAsync();
        }

        public async Task<Draw> GetDrawById(int Id)
        {
            return await _context.Draws.SingleOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<DrawResponse> JoinDraw(ApplicationUser user, int DrawId)
        {
            var draw = _context.Draws.SingleOrDefaultAsync(x => x.Id == DrawId);
            if (draw == null)
            {
                return new DrawResponse
                {
                    Code = "error",
                    Message = "draw.response.not-found",
                    Data = null
                };
            }

            user.Draw = await draw;

            return new DrawResponse
            {
                Code = "success",
                Message = "draw.join.success"
            };
        }
    }
}