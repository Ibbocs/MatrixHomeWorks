using DependencyInjectAndOptionPatter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectAndOptionPatter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private IWeatherService weatherService;
        public WeatherController(IWeatherService _weatherService) 
        { 
            weatherService= _weatherService;
        }

        [HttpGet]
        public WeatherData GetWeather(string city)
        {
            return weatherService.GetWeather(city);
        }
    }
}
