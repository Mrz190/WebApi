using AutoMapper;

namespace WebApiCourse6_7.Mapping
{
    public class PointOfInterestProfile : Profile
    {
        public PointOfInterestProfile()
        {
            CreateMap<Entities.PointOfInterest, Models.PointOFInterestDTO>();

            CreateMap<Models.PointOfInterestForCreationDTO, Entities.PointOfInterest>();
            
            CreateMap<Models.PointOfInterestForUpdatingDTO, Entities.PointOfInterest>();
            
            CreateMap<Entities.PointOfInterest, Models.PointOfInterestForUpdatingDTO>();
        }
    }
}
