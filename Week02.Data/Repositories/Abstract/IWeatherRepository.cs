using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week02.Models;

namespace Week02.Data.Repositories.Abstract
{
    public interface IWeatherRepository
    {
        Task<Weather> GetWeatherAsync(int id);
        Task<IEnumerable<Weather>> GetAllWeathersAsync();
        Task AddWeatherAsync(Weather weather);
        Task UpdateWeatherAsync(Weather weather);
        Task DeleteWeatherAsync(int id);
        Task<Weather> FindByPlanetAsync(string planet);

        Task<Weather> FindByMoonAsync(string moon);
    }
}
