using Microsoft.AspNetCore.Mvc;
using WebApiCourse6_7.Models;

namespace WebApiCourse6_7.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        private readonly ILogger<CitiesController> _logger;
        private readonly CitiesDataStore _citiesDataStore;
        public CitiesController(ILogger<CitiesController> logger, CitiesDataStore citiesDataStore)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _citiesDataStore = citiesDataStore ?? throw new ArgumentNullException(nameof(logger));
        }
        [HttpGet]
        public ActionResult<IEnumerable<CitiesDTO>> GetCities()
        {
            var resultFind = _citiesDataStore.Cities;
            if(resultFind != null)
            {
                return Ok(resultFind);
            }
            return NoContent();
        }

        [HttpGet("{id}")]
        public ActionResult<CitiesDTO> GetCity(int id)
        {
            var ResultFind = _citiesDataStore.Cities.FirstOrDefault(x => x.CityId == id);

            if(ResultFind != null) { 
                return Ok(ResultFind);
            }
            return NotFound();
        }
    }
}
