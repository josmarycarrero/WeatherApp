using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeatherAPI.Interfaces;
using WeatherAPI.StandarTypes;

namespace WeatherAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {

        private IWeatherServices _weatherServices;

        public WeatherController(IWeatherServices weatherServices)
        {
            _weatherServices = weatherServices;
        }

        // GET api/weather/getFiveDaysWeather
        [HttpGet("getFiveDaysWeather")]
        public async Task<IActionResult> GetNextFiveDaysWeatherAsync(string cityName, Unit unit = Unit.Standard, Language language = Language.en)
        {
            var forecast = await _weatherServices.GetNextFiveDaysWeather(cityName, unit, language);
            return Ok(forecast);
        }
    }
}
