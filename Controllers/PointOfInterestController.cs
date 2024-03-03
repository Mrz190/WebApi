using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using WebApiCourse6_7.Interfaces;
using WebApiCourse6_7.Models;

namespace WebApiCourse6_7.Controllers
{
    [Route("pointofinterest")]
    [ApiController]
    public class PointOfInterestController : ControllerBase
    {
        private readonly ILogger<PointOfInterestController> _logger;
        private readonly ICityInterface _cityInterface;
        private readonly IMapper _mapper;

        public PointOfInterestController(ILogger<PointOfInterestController> logger, ICityInterface cityInterface, IMapper mapper)
        {
            _cityInterface = cityInterface;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<PointOFInterestDTO>>> GetAllPointsOfInterest()
        {
            var points = await _cityInterface.GetAllPoints();
            var result = _mapper.Map<IEnumerable<PointOFInterestDTO>>(points);
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PointOFInterestDTO>>> GetPointsOfInterest(int cityId)
        {
            try
            {
                if(!await _cityInterface.CityExist(cityId))
                {
                    throw new Exception("No city");
                }
                var point = await _cityInterface.GetPointsOfInterestAsync(cityId);

                var result = _mapper.Map<IEnumerable<PointOFInterestDTO>>(point);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"Error while getting points of interest for city with id: {cityId}", ex);
                return NotFound();
            }
        }


        [HttpGet("{pointOfInterestid}", Name="GetPointOfInterest")]
        public async Task<ActionResult<PointOFInterestDTO>> GetPointOfInterest(int cityId, int pointOfInterestid)
        {
            try
            {
                if (!await _cityInterface.CityExist(cityId))
                {
                    throw new Exception("No point of interest was found.");
                }
                var pointOfInterest = await _cityInterface.GetPointOfInterestAsync(cityId, pointOfInterestid);

                if(pointOfInterest == null)
                {
                    throw new Exception("No point of interest was found.");
                }

                var result = _mapper.Map<PointOFInterestDTO>(pointOfInterest);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"Error while getting points of interest for city with id: {cityId}\n", ex);
                return NotFound();
            }
        }
        //public ActionResult<PointOFInterestDTO> GetPointOfInterest(int cityId, int pointOfInterestid)
        //{
        //    var findCity = _citiesDataStore.Cities.FirstOrDefault(x => x.CityId == cityId);
        //    var pointOfInsterest = findCity.PointOfInterests.FirstOrDefault(x => x.PointId == pointOfInterestid);

        //    if (findCity != null)
        //    {
        //        return Ok(pointOfInsterest);
        //    }



        //    return NotFound($"No city with id: {cityId}");

        //}

        //[HttpPost]
        //public ActionResult<PointOFInterestDTO> CreatePointOfInterest(int cityId, PointOfInterestForCreationDTO pointOfInterest)
        //{
        //    // 0 - validation of data
        //    // 1 - must check if city exists
        //    // 2 - find max id of pointInterest
        //    // 3 - create new PointInterest (edited in future)
        //    // 4 - add this point (edited in future)
        //    // 5 - return data for user


        //    // ---------------- 0 ----------------
        //    //if(!ModelState.IsValid)
        //    //{
        //    //    return BadRequest("Invalid data.");
        //    //}

        //    var city = _citiesDataStore.Cities.FirstOrDefault(x => x.CityId == cityId);

        //    if (city == null)
        //    {
        //        return NotFound($"No city with id: {cityId}");
        //    }

        //    var maxPointId = _citiesDataStore.Cities.SelectMany(x => x.PointOfInterests).Max(i => i.PointId);

        //    var finalPoint = new PointOFInterestDTO()
        //    {
        //        PointId = maxPointId++,
        //        PointName = pointOfInterest.PointName,
        //        PointDescription = pointOfInterest.Pointdescription
        //    };

        //    city.PointOfInterests.Add(finalPoint);


        //    return CreatedAtRoute("GetPointOfInterest", 
        //        new
        //        {
        //            cityId = cityId,
        //            pointOfInterestId = finalPoint.PointId
        //        },
        //        finalPoint);
        //}



        //[HttpPut("{pointid}")]
        //public ActionResult UpdatePointOfInterest(int cityId, int pointid, PointOfInterestForUpdatingDTO pointOfInterest)
        //{

        //    var city = _citiesDataStore.Cities.FirstOrDefault(x => x.CityId == cityId);

        //    if(city == null)
        //    {
        //        return NotFound($"No city with id: {cityId}");
        //    }


        //    //find the point in the store
        //    var pointOfInterestFromStore = city.PointOfInterests.FirstOrDefault(x => x.PointId == pointid);
        //    if(pointOfInterestFromStore == null)
        //    {
        //        return NotFound($"No point with id: {pointid}");
        //    }

        //    pointOfInterestFromStore.PointName = pointOfInterest.PointName;
        //    pointOfInterestFromStore.PointDescription = pointOfInterest.PointDescription;

        //    return NoContent();
        //}
    }
}