using AutoMapper;
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

        [HttpPost]
        public async Task<ActionResult<PointOFInterestDTO>> CreatePointOfInterest(int cityId, PointOfInterestForCreationDTO pointOfInterest)
        {
            // 0 - data validation
            // 1 - must check if city exists
            // 2 - find max id of pointInterest
            // 3 - create new PointInterest (edited in future)
            // 4 - add this point (edited in future)
            // 5 - return data for user

            var city = await _cityInterface.CityExist(cityId);

            if (city == null)
            {
                return NotFound($"No city with id: {cityId}");
            }

            var finalPoint = _mapper.Map<Entities.PointOfInterest>(pointOfInterest);

            await _cityInterface.AddPointOfInterestAsync(cityId, finalPoint);
            await _cityInterface.SaveChangesAsync();

            var resultPoint = _mapper.Map<Models.PointOFInterestDTO>(finalPoint);

            return CreatedAtRoute("GetPointOfInterest",
                new
                {
                    cityId = cityId,
                    pointOfInterestId = resultPoint.PointId
                },
                resultPoint);
        }

        [HttpPut("{pointid}")]
        public async Task<ActionResult> UpdatePointOfIntetrest(int cityId, int pointid, PointOfInterestForUpdatingDTO pointofinterest)
        {
            if(!await _cityInterface.CityExist(cityId)) return NotFound();

            var pointOfInterestEntity = await _cityInterface.GetPointOfInterestAsync(cityId, pointid);

            if(pointOfInterestEntity == null) return NotFound();

            _mapper.Map(pointofinterest, pointOfInterestEntity);
                
            await _cityInterface.SaveChangesAsync();

            return NotFound();
        }

        [HttpPatch("{pointofinterestid}")]
        public async Task<ActionResult> ParticalyUpdatePoint(int cityId, int pointid, JsonPatchDocument<PointOfInterestForUpdatingDTO> patchDocument)
        {
            if (!await _cityInterface.CityExist(cityId)) return BadRequest();

            var pointOfInterestEntity = await _cityInterface.GetPointsOfInterestAsync(cityId);

            if(pointOfInterestEntity == null) return BadRequest();

            var pointOfInterestToPatch = _mapper.Map<PointOfInterestForUpdatingDTO>(pointOfInterestEntity);

            patchDocument.ApplyTo(pointOfInterestToPatch, ModelState);

            if (!ModelState.IsValid) return BadRequest();

            if(!TryValidateModel(pointOfInterestToPatch)) return BadRequest(ModelState);

            _mapper.Map(pointOfInterestToPatch, pointOfInterestEntity);

            await _cityInterface.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{pointofinterestid}")]
        public async Task<ActionResult> DeletePointOfInterest(int cityid, int pointofinterestid)
        {
            if(!await _cityInterface.CityExist(cityid)) return BadRequest();

            var pointOfInretestEntity = await _cityInterface.GetPointOfInterestAsync(cityid, pointofinterestid);

            if(pointOfInretestEntity == null) return NotFound();

            _cityInterface.DeletePointOfInterest(pointOfInretestEntity);
            await _cityInterface.SaveChangesAsync();

            return Ok("Point of interest was successfully deleted.");
        }
    }
}