﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApiCourse6_7.Interfaces;
using WebApiCourse6_7.Models;

namespace WebApiCourse6_7.Controllers
{
    [ApiController]
    [Route("cities")]
    public class CitiesController : ControllerBase
    {
        private readonly ILogger<CitiesController> _logger;
        private readonly ICityInterface _cityInterface;
        private readonly IMapper _mapper;

        public CitiesController(ILogger<CitiesController> logger, ICityInterface cityInterface, IMapper mapper)
        {
            _logger = logger;
            _cityInterface = cityInterface;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CitiesDTO>>> GetCities()
        {
            var cityEnities = await _cityInterface.GetCitiesAsync();

            return Ok(_mapper.Map<IEnumerable<CityDTOwithoutPoints>>(cityEnities));
        }

        [HttpGet("{cityId}")]
        public async Task<ActionResult<CitiesDTO>> GetCity(int cityId, bool includepointOfInterests = false)
        {
            var city = await _cityInterface.GetCityAsync(cityId, includepointOfInterests);

            if(city == null)
            {
                return NotFound($"No city with id: {cityId}");
            }

            if(includepointOfInterests)
            {
                var result = _mapper.Map<CitiesDTO>(city);
                return Ok(result);
            }


            return BadRequest();
        }
    }
}
