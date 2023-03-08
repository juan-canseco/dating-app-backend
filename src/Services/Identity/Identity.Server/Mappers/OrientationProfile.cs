using AutoMapper;
using Identity.Server.Models;
using Identity.Server.ViewModels;

namespace Identity.Server.Mappers
{
    public class OrientationProfile : Profile
    {
        public OrientationProfile() 
        {
            CreateMap<Orientation, OrientationViewModel>();
        }
    }
}
