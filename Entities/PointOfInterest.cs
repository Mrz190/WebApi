using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiCourse6_7.Entities;

namespace WebApiCourse6_7.Entities
{
    public class PointOfInterest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PointId { get; set; }

        [Required]
        [MaxLength(50)]
        public string? PointName { get; set; }

        [MaxLength(200)]
        public string? PointDescription { get; set; }


        [ForeignKey("CityId")]
        public City? City { get; set; }
        public int CityId { get; set; }
    }
}