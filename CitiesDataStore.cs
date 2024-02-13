using WebApiCourse6_7.Models;

namespace WebApiCourse6_7
{
    public class CitiesDataStore
    {
        public List<CitiesDTO> Cities { get; set; }
        public static CitiesDataStore Current { get; set; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CitiesDTO>()
            {
                new CitiesDTO()
                {
                    CityId = 1,
                    CityName = "Moscow",
                    CityDescription = "Great City",
                    PointOfInterests = new List<PointOFInterestDTO>
                    {
                        new PointOFInterestDTO()
                        {
                            PointId = 1,
                            PointName = "City Center",
                            PointDescription = ""
                        }
                    }
                },
                new CitiesDTO()
                {
                    CityId = 2,
                    CityName = "Vitebsk",
                    CityDescription = null,
                    PointOfInterests = new List<PointOFInterestDTO>
                    {
                        new PointOFInterestDTO()
                        {
                            PointId = 2,
                            PointName = "clock"
                        }
                    }
                }
            };
        }
    }
}
