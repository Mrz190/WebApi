using System.ComponentModel.DataAnnotations;

namespace WebApiCourse6_7.Models
{
    public class PointOfInterestForCreationDTO
    {
        [Required(ErrorMessage = "You must provide the name value.")]
        [MaxLength(50)]
        public string PointName { get; set; }

        public string Pointdescription { get; set; }
    }
}
