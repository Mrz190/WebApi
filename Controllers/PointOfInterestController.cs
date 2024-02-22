using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using WebApiCourse6_7.Models;

namespace WebApiCourse6_7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PointOfInterestController : ControllerBase
    {
        private readonly ILogger<PointOfInterestController> _logger;
        private readonly CitiesDataStore _citiesDataStore;

        [HttpGet]
        public ActionResult<IEnumerable<PointOFInterestDTO>> GetPointsOfInterest(int cityId)
        {
            try
            {
                //throw new Exception("Sample Error");
                
                var city = _citiesDataStore.Cities.FirstOrDefault(x => x.CityId == cityId);
                if (city == null)
                {
                    _logger.LogInformation($"No city with id: {cityId}");
                    return NotFound();
                }

                return Ok(city.PointOfInterests);
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"Error while getting points of interest for city with id: {cityId}", ex);
                return StatusCode(500, "A problem happend while handling your request");
            }
        }

        [HttpGet("{pointOfInterestid}", Name="GetPointOfInterest")]
        public ActionResult<PointOFInterestDTO> GetPointOfInterest(int cityId, int pointOfInterestid)
        {
            var findCity = _citiesDataStore.Cities.FirstOrDefault(x => x.CityId == cityId);
            var pointOfInsterest = findCity.PointOfInterests.FirstOrDefault(x => x.PointId == pointOfInterestid);

            if (findCity != null)
            {
                return Ok(pointOfInsterest);
            }

            

            return NotFound($"No city with id: {cityId}");

        }

        [HttpPost]
        public ActionResult<PointOFInterestDTO> CreatePointOfInterest(int cityId, PointOfInterestForCreationDTO pointOfInterest)
        {
            // 0 - validation of data
            // 1 - must check if city exists
            // 2 - find max id of pointInterest
            // 3 - create new PointInterest (edited in future)
            // 4 - add this point (edited in future)
            // 5 - return data for user


            // ---------------- 0 ----------------
            //if(!ModelState.IsValid)
            //{
            //    return BadRequest("Invalid data.");
            //}

            var city = _citiesDataStore.Cities.FirstOrDefault(x => x.CityId == cityId);

            if (city == null)
            {
                return NotFound($"No city with id: {cityId}");
            }

            var maxPointId = _citiesDataStore.Cities.SelectMany(x => x.PointOfInterests).Max(i => i.PointId);
            
            var finalPoint = new PointOFInterestDTO()
            {
                PointId = maxPointId++,
                PointName = pointOfInterest.PointName,
                PointDescription = pointOfInterest.Pointdescription
            };

            city.PointOfInterests.Add(finalPoint);


            return CreatedAtRoute("GetPointOfInterest", 
                new
                {
                    cityId = cityId,
                    pointOfInterestId = finalPoint.PointId
                },
                finalPoint);
        }



        [HttpPut("{pointid}")]
        public ActionResult UpdatePointOfInterest(int cityId, int pointid, PointOfInterestForUpdatingDTO pointOfInterest)
        {

            var city = _citiesDataStore.Cities.FirstOrDefault(x => x.CityId == cityId);

            if(city == null)
            {
                return NotFound($"No city with id: {cityId}");
            }


            //find the point in the store
            var pointOfInterestFromStore = city.PointOfInterests.FirstOrDefault(x => x.PointId == pointid);
            if(pointOfInterestFromStore == null)
            {
                return NotFound($"No point with id: {pointid}");
            }

            pointOfInterestFromStore.PointName = pointOfInterest.PointName;
            pointOfInterestFromStore.PointDescription = pointOfInterest.PointDescription;

            return NoContent();
        }
    }
}