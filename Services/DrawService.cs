using System.Collections.Generic;
using System.Threading.Tasks;
using FestivalVar.Data;
using FestivalVar.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FestivalVar.Services
{
    public class DrawService : IDrawService
    {
        private readonly DataContext _context;
        private readonly UserManager<>
        
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

        public async Task<Draw> JoinDraw()
        {
            var user = _context.User
        }
    }
}