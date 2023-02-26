using DependencyInjectAndOptionPatter.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DependencyInjectAndOptionPatter
{
    public class WeatherService : IWeatherService
    {
        public WeatherData GetWeather(string _city)
        {
            var rng = new Random();
            var temperatureC = rng.Next(-20, 55);

            try
            {
                return new WeatherData { city = _city, temperature = temperatureC };
            }
            catch (Exception ex)
            {
                return new WeatherData { MyException = ex.Message };
            }
            

            //return Enumerable.Range(1, 5).Select(index => new WeatherData
            //{
            //    temperature = rng.Next(-20, 55),
            //    city = _city,
                
            //})
            //.ToArray();
        }

        
    }
}
