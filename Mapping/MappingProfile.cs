using AutoMapper;
using BladeRunnerApp.Controllers.Resources;
using BladeRunnerApp.Models;

namespace BladeRunnerApp.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserResource>();
            CreateMap<UserRole, UserRoleResource>();
        }
    }
}