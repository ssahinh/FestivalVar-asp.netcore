using System.Collections.Generic;
using System.Threading.Tasks;
using FestivalVar.Data;
using FestivalVar.Domain;
using Microsoft.EntityFrameworkCore;

namespace FestivalVar.Services
{
    public class ContractService : IContractService
    {
        private readonly DataContext _dataContext;

        public ContractService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Contract>> GetContractsAsync()
        {
            return await _dataContext.Contracts.ToListAsync();
        }

        public async Task<Contract> GetContractByIdAsync(int Id)
        {
            return await _dataContext.Contracts.SingleOrDefaultAsync(x => x.Id == Id);        }
    }
}