using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherAPI.Models;
using WeatherAPI.StandarTypes;

namespace WeatherAPI.Interfaces
{
    public interface IWeatherServices
    {
        Task<IEnumerable<ForecastItem>> GetNextFiveDaysWeather(string cityName, Unit unit = Unit.Standard, Language language = Language.en);
    }
}