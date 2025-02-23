using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FestivalVar.Data;
using FestivalVar.Domain;
using Microsoft.EntityFrameworkCore;

namespace FestivalVar.Services
{
    public class FestivalService : IFestivalService
    {
        private readonly DataContext _dataContext;

        public FestivalService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Festival>> GetFestivalsAsync()
        {
            return await _dataContext.Festivals
                .Include(festival => festival.Category)
                .ToListAsync();
        }

        public async Task<bool> CreateFestivalAsync(Festival festival)
        {
            await _dataContext.Festivals.AddAsync(festival);

            var created = await _dataContext.SaveChangesAsync();

            return created > 0;
        }

        public Task<Festival> GetFestivalById(int festivalId)
        {
            return _dataContext.Festivals.SingleOrDefaultAsync(x => x.Id == festivalId);
        }
    }
}