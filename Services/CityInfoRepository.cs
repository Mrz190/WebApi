using Microsoft.EntityFrameworkCore;
using WebApiCourse6_7.Data;
using WebApiCourse6_7.Entities;
using WebApiCourse6_7.Interfaces;

namespace WebApiCourse6_7.Services
{
    public class CityInfoRepository : ICityInterface
    {
        private readonly DataContext _context;
        public CityInfoRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<City>> GetCitiesAsync()
        {
            return await _context.Cities.OrderBy(c => c.CityName).ToListAsync();
        }

        public async Task<IEnumerable<City>> GetCitiesAsync(string? name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return await GetCitiesAsync();
            }
            name = name.Trim();
            return await _context.Cities
                         .Where(c => c.CityName == name)
                         .OrderBy(c => c.CityName)
                         .ToListAsync();
        }

        public async Task<City> GetCityAsync(int cityId, bool includepointOfInterests)
        {
            var city = await _context.Cities.Include(p => p.PointsOfInterest).Where(i => i.CityId == cityId).FirstOrDefaultAsync();
            return city;
        }

        public async Task CreateCity(City city)
        {
            _context.Add(city);
        }

        public async Task<bool> CityExist(int cityid)
        {
            return await _context.Cities.AnyAsync(c => c.CityId == cityid);
        }

        public async Task<PointOfInterest> GetPointOfInterestAsync(int cityId, int pointId)
        {
            var point = await _context.PointOfInterests.Where(i => i.CityId == cityId && i.PointId == pointId).FirstOrDefaultAsync();
            return point;
        }

        public async Task<IEnumerable<PointOfInterest>> GetPointsOfInterestAsync(int cityId)
        {
            return await _context.PointOfInterests.Where(i => i.CityId == cityId).OrderBy(n => n.PointName).ToListAsync();
        }

        public async Task<IEnumerable<PointOfInterest>> GetAllPoints()
        {
            return await _context.PointOfInterests.ToListAsync();
        }
        public async Task<IEnumerable<PointOfInterest>> GetAllPoints(string? name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return await GetAllPoints();
            }
            return await _context.PointOfInterests
                                  .Where(n => n.PointName == name)
                                  .OrderBy(n => n.PointName)
                                  .ToListAsync();
        }

        public async Task AddPointOfInterestAsync(int cityId, PointOfInterest pointOfInterest)
        {
            var city = await GetCityAsync(cityId, false);

            if (city != null) city.PointsOfInterest.Add(pointOfInterest);
        }

        public void DeletePointOfInterest(PointOfInterest pointOfInterest)
        {
            _context.PointOfInterests.Remove(pointOfInterest);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }
    }
}