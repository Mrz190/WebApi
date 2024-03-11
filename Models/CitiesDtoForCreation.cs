using System.ComponentModel.DataAnnotations;

namespace WebApiCourse6_7.Models
{
    public class CitiesDtoForCreation
    {
        [Required(ErrorMessage = "You Must provide the name value")]
        [MaxLength(50)]
        public string CityName { get; set; }
        public string CityDescription { get; set; }
    }
}
