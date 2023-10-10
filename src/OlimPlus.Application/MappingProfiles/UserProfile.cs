using AutoMapper;
using OlimPlus.Application.DTO.User;
using OlimPlus.Domain;

namespace OlimPlus.Application.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<CreateUserDto, User>().ReverseMap();
        }
    }
}