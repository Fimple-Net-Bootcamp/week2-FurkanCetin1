using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week02.Data.Repositories.Abstract;
using Week02.Models;

namespace Week02.Data.Repositories.Concrete
{
    public class WeatherRepository : IWeatherRepository
    {
        private readonly ApplicationDbContext _context;

        public WeatherRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddWeatherAsync(Weather weather)
        {
            _context.Weathers.Add(weather);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteWeatherAsync(int id)
        {
            var weather = await GetWeatherAsync(id);
            if (weather != null)
            {
                _context.Weathers.Remove(weather);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Weather>> GetAllWeathersAsync()
        {
            return await _context.Weathers.ToListAsync();
        }

        public async Task<Weather> GetWeatherAsync(int id)
        {
            return await _context.Weathers.FindAsync(id);
        }

        public async Task UpdateWeatherAsync(Weather weather)
        {
            _context.Weathers.Update(weather);
            await _context.SaveChangesAsync();
        }

        public async Task<Weather> FindByPlanetAsync(string planet)
        {
            return await _context.Weathers
                             .FirstOrDefaultAsync(w => w.PlanetName.Equals(planet, StringComparison.OrdinalIgnoreCase));
        }

        public async Task<Weather> FindByMoonAsync(string moon)
        {
            return await _context.Weathers
                         .FirstOrDefaultAsync(w => w.Moon.ToLower() == moon.ToLower());
        }
    }
}
