using System.Collections.Generic;
using System.Threading.Tasks;
using FestivalVar.Domain;

namespace FestivalVar.Services
{
    public interface IContractService
    {
        Task<List<Contract>> GetContractsAsync();
        Task<Contract> GetContractById(int Id);
    }
}