using AutoMapper;
using PawnShopBE.Core.DTOs;
using PawnShopBE.Core.Models;

namespace PawnShopBE.Helpers
{
    public class UserProfile : Profile
    {
        public UserProfile()
            {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
            }
    }
}
