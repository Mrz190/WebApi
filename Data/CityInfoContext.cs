using Microsoft.EntityFrameworkCore;
using WebApiCourse6_7.Entities;

namespace WebApiCourse6_7.Data
{
    public class CityInfoContext : DbContext
    {
        public CityInfoContext()
        {
            
        }
        public CityInfoContext(DbContextOptions<CityInfoContext> options) : base(options)
        {

        }

        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<PointOfInterest> PointOfInterests { get; set; } = null!;
    }
}