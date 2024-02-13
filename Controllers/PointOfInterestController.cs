using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCourse6_7.Models;

namespace WebApiCourse6_7.Controllers
{
    [Route("api/cities/{cityId}/view")]
    [ApiController]
    public class PointOfInterestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<PointOFInterestDTO>> GetPointsOfInterest(int cityId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.CityId == cityId);
            if(city == null)
            {
                return NotFound($"No city with id: {cityId}");
            }

            return Ok(city.PointOfInterests);
        }

        [HttpGet("{pointOfInterestid}", Name="GetPointOfInterest")]
        public ActionResult<PointOFInterestDTO> GetPointOfInterest(int cityId, int pointOfInterestid)
        {
            var findCity = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.CityId == cityId);

            if(findCity == null)
            {
                return NotFound($"No city with id: {cityId}");
            }

            var pointOfInsterest = findCity.PointOfInterests.FirstOrDefault(x => x.PointId == pointOfInterestid);

            if(pointOfInsterest == null)
            {
                return NotFound("No points was found :(");
            }

            return Ok(pointOfInsterest);
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

            var city = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.CityId == cityId);

            if (city == null)
            {
                return NotFound($"No city with id: {cityId}");
            }

            var maxPointId = CitiesDataStore.Current.Cities.SelectMany(x => x.PointOfInterests).Max(i => i.PointId);
            
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

            var city = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.CityId == cityId);

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