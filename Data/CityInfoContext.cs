using WebApiCourse6_7.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

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

            var jsonCities = File.ReadAllText("Data/SeedCity.json");

            var cities = JsonSerializer.Deserialize<List<City>>(jsonCities);


            foreach (var city in cities)
            {
                modelBuilder.Entity<City>().HasData(city);
            }



            var jsonPoints = File.ReadAllText("Data/SeedPoints.json");

            var points = JsonSerializer.Deserialize<List<PointOfInterest>>(jsonPoints);

            foreach(var point in points)
            {
                point.CityId = Convert.ToInt32(point.CityId);
                modelBuilder.Entity<PointOfInterest>().HasData(point);
            }

            base.OnModelCreating(modelBuilder);

        }
    }
}