using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherAPI.Models;
using WeatherAPI.Models.Enums;

namespace WeatherAPI.Interfaces
{
    public interface IWeatherServices
    {
        Task<WeatherForecast> GetNextFiveDaysWeather(string cityName, Unit unit = Unit.Standard, Language language = Language.en);
    }
}
