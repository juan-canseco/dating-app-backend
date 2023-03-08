using AutoMapper;
using Identity.Server.Models;
using Identity.Server.ViewModels;

namespace Identity.Server.Mappers
{
    public class GenderProfile : Profile
    {
        public GenderProfile() 
        {
            CreateMap<Gender, GenderViewModel>();
        }
    }
}
