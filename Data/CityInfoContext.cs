using WebApiCourse6_7.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebApiCourse6_7.Data
{
    public class CityInfoContext : DbContext
    {
        public CityInfoContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public CityInfoContext(DbContextOptions<CityInfoContext> options) : base(options)
        {
        }

        public DbSet<City> Cities { get; set; } = null!;

        public DbSet<PointOfInterest> PointOfInterests { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City
                {
                    CityId = 1,
                    CityName = "Moscow",
                    CityDescription = "Great Business City"
                },
                new City
                {
                    CityId = 2,
                    CityName = "NewYork",
                    CityDescription = "Live City"
                });

            modelBuilder.Entity<PointOfInterest>().HasData(
                new PointOfInterest
                {
                    PointId = 1,
                    CityId = 1,
                    PointName = "Moscow City",
                },
                new PointOfInterest
                {
                    PointId = 2,
                    CityId = 1,
                    PointName = "Kreml"
                },
                new PointOfInterest
                {
                    PointId = 3,
                    CityId = 2,
                    PointName = "Central Park"
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}