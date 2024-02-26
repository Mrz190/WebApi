using AutoMapper;
using System.Runtime.InteropServices;

namespace WebApiCourse6_7.Profiles
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<Entities.City, Models.CityDTOwithoutPoints>();
        }
    }
}
