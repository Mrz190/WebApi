namespace WebApiCourse6_7.Models
{
    public class CitiesDTO
    {
        public int CityId { get; set; }
        public string CityName { get; set; } = string.Empty;
        public string CityDescription { get; set; }
        public int numberPointOfInterest
        {
            get => PointOfInterests.Count;
        }

        public ICollection<PointOFInterestDTO> PointOfInterests { get; set; } = new List<PointOFInterestDTO>();
    }
}
