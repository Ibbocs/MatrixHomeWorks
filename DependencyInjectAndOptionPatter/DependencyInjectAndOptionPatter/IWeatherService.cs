using DependencyInjectAndOptionPatter.Models;
using System.Collections.Generic;

namespace DependencyInjectAndOptionPatter
{
    public interface IWeatherService
    {
        public WeatherData GetWeather(string city);
    }
}
