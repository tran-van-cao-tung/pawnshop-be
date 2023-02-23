using AutoMapper;
using PawnShopBE.Core.DTOs;
using PawnShopBE.Core.Models;

namespace PawnShopBE.Helpers
{
    public class MappingProfile : Profile 
    {
        public MappingProfile()
        {
            // Mapping tu DTO sang entity
            CreateMap<Role, RoleDTO>().ReverseMap();
            CreateMap<Contract, ContractDTO>().ReverseMap();         
            CreateMap<BranchDTO, Branch>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<AttributeDTO, Core.Models.Attribute>();
            CreateMap<PawnableProductDTO, PawnableProduct>()
                .ForMember(
                    dest => dest.Attributes,
                    opt => opt.MapFrom(src => src.AttributeDTOs));
            
        }
    }
}
