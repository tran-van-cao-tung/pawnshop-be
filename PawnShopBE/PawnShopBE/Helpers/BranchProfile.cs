using AutoMapper;
using PawnShopBE.Core.DTOs;
using PawnShopBE.Core.Models;

namespace PawnShopBE.Helpers
{
    public class BranchProfile : Profile
    {
        public BranchProfile()
        {
            CreateMap<BranchDTO, Branch>();
            CreateMap<Branch, BranchDTO>();
        }
    }
}
