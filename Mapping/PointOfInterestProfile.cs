using AutoMapper;

namespace WebApiCourse6_7.Mapping
{
    public class PointOfInterestProfile : Profile
    {
        public PointOfInterestProfile()
        {
            CreateMap<Entities.PointOfInterest, Models.PointOFInterestDTO>();
        }
    }
}
