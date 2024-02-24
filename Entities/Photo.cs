using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiCourse6_7.Entities
{
    [Table("Photo")]
    public class Photo
    {
        public int PhotoId { get; set; }
        public string Url { get; set; }
    }
}
