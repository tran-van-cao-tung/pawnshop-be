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
            CreateMap<Customer, CustomerDTO>().ReverseMap();
            CreateMap<Kyc,KycDTO>().ReverseMap();
            CreateMap<Job, JobDTO>().ReverseMap();
        }
    }
}
