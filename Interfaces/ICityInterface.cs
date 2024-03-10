using Microsoft.AspNetCore.Mvc;
using WebApiCourse6_7.Entities;

namespace WebApiCourse6_7.Interfaces
{
    public interface ICityInterface
    {
        Task<IEnumerable<City>> GetCitiesAsync();
        Task<City> GetCityAsync(int cityId, bool includepointOfInterests);
        Task<bool> CityExist(int cityid);
        Task<IEnumerable<PointOfInterest>> GetPointsOfInterestAsync(int cityId);
        Task<PointOfInterest> GetPointOfInterestAsync(int cityId, int pointId);
        Task<IEnumerable<PointOfInterest>> GetAllPoints();
        Task AddPointOfInterestAsync(int cityId, PointOfInterest pointOfInterest);
        Task<bool> SaveChangesAsync();
    }
}
