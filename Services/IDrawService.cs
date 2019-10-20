using System.Collections.Generic;
using System.Threading.Tasks;
using FestivalVar.Domain;
using FestivalVar.Domain.Utils.Responses;
using Microsoft.AspNetCore.Identity;

namespace FestivalVar.Services
{
    public interface IDrawService
    {
        Task<List<Draw>> GetAllDraws();

        Task<Draw> GetDrawById(int Id);

    }
}