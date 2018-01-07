using AutoMapper;
using System.Linq;
using BladeRunnerApp.Controllers.Resources;
using BladeRunnerApp.Models;

namespace BladeRunnerApp.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to API Resource
            CreateMap<User, UserResource>()
                .ForMember(ur => ur.Contact, opt => opt.MapFrom(u =>
                 new ContactResource { Name = u.FirstName, LastName = u.LastName, Phone = u.PhoneNumber, Email = u.Email} ))
                .ForMember(ur => ur.UserRoleId, opt => opt.MapFrom(u => u.UserRoleId))
                .ForMember(ur => ur.CreatedAt, opt => opt.MapFrom(u => u.CreatedAt));
            CreateMap<UserRole, UserRoleResource>();

            // API Resource to Domain
            CreateMap<UserResource, User>()
                .ForMember(u => u.FirstName, opt => opt.MapFrom(ur => ur.Contact.Name))
                .ForMember(u => u.LastName, opt => opt.MapFrom(ur => ur.Contact.LastName))
                .ForMember(u => u.Email, opt => opt.MapFrom(ur => ur.Contact.Email))
                .ForMember(u => u.PhoneNumber, opt => opt.MapFrom(ur => ur.Contact.Phone));
        }
    }
}