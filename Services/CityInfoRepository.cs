using Microsoft.EntityFrameworkCore;
using WebApiCourse6_7.Data;
using WebApiCourse6_7.Entities;
using WebApiCourse6_7.Interfaces;

namespace WebApiCourse6_7.Services
{
    public class CityInfoRepository : ICityInterface
    {
        private DataContext _context;
        public CityInfoRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<City>> GetCitiesAsync()
        {
            return await _context.Cities.OrderBy(c => c.CityName).ToListAsync();
        }

        public async Task<City> GetCityAsync(int cityId, bool includepointOfInterests)
        {
            var city = await _context.Cities.Include(p => p.PointsOfInterest).Where(i => i.CityId == cityId).FirstOrDefaultAsync();
            return city;
            //var result = await _context.Cities.Where(i => i.CityId == cityId).FirstOrDefaultAsync();
            //return result;
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

        public async Task AddPointOfInterestAsync(int cityId, PointOfInterest pointOfInterest)
        {
            var city = await GetCityAsync(cityId, false);

            if(city != null)
            {
                city.PointsOfInterest.Add(pointOfInterest);
            }
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }
    }
}
