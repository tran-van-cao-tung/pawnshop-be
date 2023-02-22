using AutoMapper;
using PawnShopBE.Core.DTOs;
using PawnShopBE.Core.Models;

namespace PawnShopBE.Helpers
{
    public class ContractProfile : Profile
    {
        public ContractProfile()
        {
            CreateMap<Contract, ContractDTO>();
            CreateMap<ContractDTO, Contract>();
        }
    }
}
