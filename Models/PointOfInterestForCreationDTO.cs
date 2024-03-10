using System.ComponentModel.DataAnnotations;

namespace WebApiCourse6_7.Models
{
    public class PointOfInterestForCreationDTO
    {
        [Required(ErrorMessage = "You must provide the name value.")]
        [MaxLength(25)]
        public string PointName { get; set; } = string.Empty;

        [MaxLength(200)]
        public string Pointdescription { get; set; }
    }
}
