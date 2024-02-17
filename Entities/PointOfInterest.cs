using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiCourse6_7.Entities
{
    public class PointOfInterest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PointId { get; set; }
        
        [Required]
        public string PointName { get; set; }
        
        [MaxLength(200)]
        public string? PointDescription { get; set; }
        
        [ForeignKey("cityId")]
        public City? City { get; set; }
        public int CityId { get; set; }
        
        public PointOfInterest(string name)
        {
            PointName = name;
        }
    }
}
