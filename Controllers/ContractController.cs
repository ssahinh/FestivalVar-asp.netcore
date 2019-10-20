using System.Threading.Tasks;
using FestivalVar.Domain.Utils.Responses;
using FestivalVar.Services;
using Microsoft.AspNetCore.Mvc;

namespace FestivalVar.Controllers
{  
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class ContractController : Controller
    {
        private readonly IContractService _contractService;

        public ContractController(IContractService contractService)
        {
            _contractService = contractService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllContracts()
        {
            var model = await _contractService.GetContractsAsync();

            if (model == null)
            {
                return NotFound();
            }
            
            var response = new ContractResponse
            {
                Code = "success",
                Message = "contract.all.get.success",
                Data = model
            };

            return Created("", response);
        }
    }
}