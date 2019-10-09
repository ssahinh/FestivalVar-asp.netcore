using System.Collections.Generic;
using System.Threading.Tasks;
using FestivalVar.Domain;

namespace FestivalVar.Services
{
    public interface IFestivalService
    {
        Task<List<Festival>> GetFestivalsAsync();
        
        Task<bool> CreateFestivalAsync(Festival festival);

        Task<Festival> GetFestivalById(int festivalId);
    }
}