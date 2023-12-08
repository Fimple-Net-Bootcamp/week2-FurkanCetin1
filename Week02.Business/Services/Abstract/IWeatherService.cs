using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week02.Models;

namespace Week02.Business.Services.Abstract
{
    public interface IWeatherService
    {
        Task<Weather> GetWeatherAsync(int id);
        Task<IEnumerable<Weather>> GetAllWeathersAsync();
        Task CreateWeatherAsync(Weather weather);
        Task UpdateWeatherAsync(Weather weather);
        Task DeleteWeatherAsync(int id);
        Task<Weather> GetWeatherByPlanetAsync(string planet);

        Task<Weather> GetWeatherByMoonAsync(string moon);

    }
}
