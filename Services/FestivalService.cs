using System.Collections.Generic;
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
            return await _dataContext.Festivals.ToListAsync();
        }

        public async Task<bool> CreateFestivalAsync(Festival festival)
        {
            await _dataContext.Festivals.AddAsync(festival);

            var created = await _dataContext.SaveChangesAsync();

            return created > 0;
        }
    }
}