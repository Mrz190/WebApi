using AutoMapper;
using WebApiCourse6_7.Entities;

namespace WebApiCourse6_7.Mapping
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<Entities.City, Models.CityDTOwithoutPoints>();
            
            CreateMap<Entities.City, Models.CitiesDTO>()
                .ForMember(dest => dest.PointOfInterests, opt => opt.MapFrom(src => src.PointsOfInterest.ToList()));
        }
    }
}
