using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PawnShopBE.Core.DTOs;
using PawnShopBE.Core.Models;
using Services.Services;
using Services.Services.IServices;

namespace PawnShopBE.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        private readonly IContractService _contractService;
        private readonly IMapper _mapper;

        public ContractController(IContractService contractService, IMapper mapper)
        {
            _contractService = contractService;
            _mapper = mapper;
        }

        [HttpPost("contract")]
        public async Task<IActionResult> CreateContract(ContractDTO request)
        {
            var contract = _mapper.Map<Contract>(request);
            var response = await _contractService.CreateContract(contract);

            if (response)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
