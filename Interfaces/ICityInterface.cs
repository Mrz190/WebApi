using WebApiCourse6_7.Entities;

namespace WebApiCourse6_7.Interfaces
{
    public interface ICityInterface : IDisposable
    {
        Task<IEnumerable<City>> GetCitiesAsync();
        Task<City>? GetCityAsync(int cityId, bool includepointOfInterests);
        Task<IEnumerable<PointOfInterest>> GetPointsOfInterestAsync(int cityId);
        Task<PointOfInterest>? GetPointOfInterestAsync(int cityId, int pointId);
    }
}
