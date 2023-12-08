using Microsoft.AspNetCore.Mvc;
using Week02.Business.Services.Abstract;
using Week02.Models;

namespace Week02.Api.Controllers
{
    [ApiController]
    [Route("api/v1/weather")]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        // GET /api/v1/weather/mars
        [HttpGet("{planet}")]
        public async Task<IActionResult> GetWeather(string planet)
        {
            var weather = await _weatherService.GetWeatherByPlanetAsync(planet);
            if (weather != null)
                return Ok(weather);

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> CreateWeather([FromBody] Weather weather)
        {
            await _weatherService.CreateWeatherAsync(weather);
            return CreatedAtAction(nameof(CelestialBodiesController.GetPlanetWeather), new { planet = weather.PlanetName }, weather);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateWeather(int id, [FromBody] Weather weather)
        {
            if (id != weather.Id)
            {
                return BadRequest();
            }

            await _weatherService.UpdateWeatherAsync(weather);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWeather(int id)
        {
            var weatherToDelete = await _weatherService.GetWeatherAsync(id);
            if (weatherToDelete == null)
            {
                return NotFound();
            }

            await _weatherService.DeleteWeatherAsync(id);
            return NoContent();
        }
    }
}
