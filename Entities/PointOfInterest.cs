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
        [MaxLength(50)]
        public string? PointName { get; set; }

        public string? PointDescription { get; set; }


        [ForeignKey("CityId")]
        public City? City { get; set; }
        public int CityId { get; set; }
    }
}