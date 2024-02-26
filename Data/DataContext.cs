using WebApiCourse6_7.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace WebApiCourse6_7.Data
{
    public class DataContext : IdentityDbContext<AppUser, IdentityRole<int>, int>
    {
        public DataContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        
        public DbSet<City> Cities { get; set; } = null!;

        public DbSet<PointOfInterest> PointOfInterests { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var jsonCity = File.ReadAllText("Data/SeedCity.json");

            var city_data = JsonSerializer.Deserialize<List<City>>(jsonCity);

            foreach(var city in city_data)
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