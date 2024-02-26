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
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void Dispose()
        {
        }

        public async Task<IEnumerable<City>> GetCitiesAsync()
        {
            return await _context.Cities.OrderBy(c => c.CityName).ToListAsync();
        }

        public async Task<City>? GetCityAsync(int cityId, bool includepointOfInterests)
        {
            if(includepointOfInterests)
            {
                return await _context.Cities.Include(p => p.PointsOfInterest).Where(i => i.CityId == cityId).FirstOrDefaultAsync();
            }
            return await _context.Cities.Where(i => i.CityId == cityId).FirstOrDefaultAsync();
        }

        public async Task<PointOfInterest> GetPointOfInterestAsync(int cityId, int pointId)
        {
            return await _context.PointOfInterests.Where(i => i.CityId == cityId && i.PointId == pointId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<PointOfInterest>> GetPointsOfInterestAsync(int cityId)
        {
            return await _context.PointOfInterests.Where(i => i.CityId == cityId).OrderBy(n => n.PointName).ToListAsync();
        }
    }
}
