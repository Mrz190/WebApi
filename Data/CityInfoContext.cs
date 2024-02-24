using WebApiCourse6_7.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace WebApiCourse6_7.Data
{
    public class CityInfoContext : DbContext
    {
        public CityInfoContext(DbContextOptions<CityInfoContext> options) : base(options)
        {
        }

        public DbSet<City> Cities { get; set; } = null!;

        public DbSet<PointOfInterest> PointOfInterests { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var json_City = File.ReadAllText("Data/SeedCity.json");

            var city_data = JsonSerializer.Deserialize<List<City>>(json_City);

            foreach(var user in city_data)
            {
                modelBuilder.Entity<City>().HasData(user);
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