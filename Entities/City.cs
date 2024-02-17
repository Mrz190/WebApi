using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiCourse6_7.Models;

namespace WebApiCourse6_7.Entities
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityId { get; set; }

        [Required]
        [MaxLength(50)]
        public string CityName { get; set; }

        [MaxLength(200)]
        public string? CityDescription { get; set; }
        public ICollection<PointOfInterest> pointOfInterest { get; set; } = new List<PointOfInterest>();

        public City(string name)
        {
            CityName = name;
        }
    }
}
