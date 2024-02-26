using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApiCourse6_7.Interfaces;
using WebApiCourse6_7.Models;

namespace WebApiCourse6_7.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        private readonly ILogger<CitiesController> _logger;
        private readonly ICityInterface _cityInterface;
        private readonly IMapper _mapper;

        public CitiesController(ILogger<CitiesController> logger, ICityInterface cityInterface, IMapper mapper)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _cityInterface = cityInterface ?? throw new ArgumentNullException(nameof(cityInterface));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CitiesDTO>>> GetCities()
        {
            var cityEnities = await _cityInterface.GetCitiesAsync();

            return Ok(_mapper.Map<IEnumerable<CityDTOwithoutPoints>>(cityEnities));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CitiesDTO>> GetCity(int id)
        {
            return Ok();
            //var cityToReturn = await _cityInterface.GetCityAsync(id);
            //return await Ok(cityToReturn);
        }
    }
}
