using System.ComponentModel.DataAnnotations;

namespace WebApiCourse6_7.Models
{
    public class PointOfInterestForUpdatingDTO
    {
        [Required(ErrorMessage = "You must provide the name value.")]
        public string PointName { get; set; }

        public string PointDescription { get; set; }
    }
}
