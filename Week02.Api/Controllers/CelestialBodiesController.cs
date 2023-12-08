using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week02.Business.Services.Abstract;

namespace Week02.Api.Controllers
{
    [Route("api/v1/celestial-bodies")]
    [ApiController]
    public class CelestialBodiesController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public CelestialBodiesController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        // Gezegenin hava durumu için endpoint
        [HttpGet("planets/{name}")]
        public async Task<IActionResult> GetPlanetWeather(string name)
        {
            var weather = await _weatherService.GetWeatherByPlanetAsync(name);
            if (weather != null)
                return Ok(weather);

            return NotFound(new { Message = $"Weather information for planet {name} not found." });
        }

        // Uydunun hava durumu için endpoint
        [HttpGet("moons/{name}")]
        public async Task<IActionResult> GetMoonWeather(string name)
        {
            var weather = await _weatherService.GetWeatherByMoonAsync(name);
            if (weather != null)
                return Ok(weather);

            return NotFound(new { Message = $"Weather information for moon {name} not found." });
        }
    }
}
