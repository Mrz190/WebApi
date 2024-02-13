using Microsoft.AspNetCore.Mvc;
using WebApiCourse6_7.Models;

namespace WebApiCourse6_7.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<CitiesDTO>> GetCities()
        {
            var resultFind = CitiesDataStore.Current.Cities;
            if(resultFind != null)
            {
                return Ok(resultFind);
            }
            return NoContent();
        }

        [HttpGet("{id}")]
        public ActionResult<CitiesDTO> GetCity(int id)
        {
            var ResultFind = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.CityId == id);

            if(ResultFind != null) { 
                return Ok(ResultFind);
            }
            return NotFound();
        }
    }
}
