using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week02.Business.Services.Abstract;
using Week02.Data.Repositories.Abstract;
using Week02.Models;

namespace Week02.Business.Services.Concrete
{
    public class WeatherService:IWeatherService
    {
        private readonly IWeatherRepository _weatherRepository;

        public WeatherService(IWeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository;
        }

        public async Task<Weather> GetWeatherAsync(int id)
        {
            return await _weatherRepository.GetWeatherAsync(id);
        }

        public async Task<IEnumerable<Weather>> GetAllWeathersAsync()
        {
            return await _weatherRepository.GetAllWeathersAsync();
        }

        public async Task CreateWeatherAsync(Weather weather)
        {
            await _weatherRepository.AddWeatherAsync(weather);
        }

        public async Task UpdateWeatherAsync(Weather weather)
        {
            await _weatherRepository.UpdateWeatherAsync(weather);
        }

        public async Task DeleteWeatherAsync(int id)
        {
            await _weatherRepository.DeleteWeatherAsync(id);
        }

        public async Task<Weather> GetWeatherByPlanetAsync(string planet)
        {
            var weather = await _weatherRepository.FindByPlanetAsync(planet);
            return weather;
        }
        public async Task<Weather> GetWeatherByMoonAsync(string moon)
        {
            var weather = await _weatherRepository.FindByPlanetAsync(moon);
            return weather;
        }
    }
}
