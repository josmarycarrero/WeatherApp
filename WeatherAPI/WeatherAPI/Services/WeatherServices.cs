using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherAPI.Helpers;
using WeatherAPI.Interfaces;
using WeatherAPI.Models;
using WeatherAPI.StandarTypes;

namespace WeatherAPI.Services
{
    public class WeatherServices : IWeatherServices
    {
        private WeatherRequestBuilder _requestBuilder;

        public WeatherServices(IOptions<AppSettings> appSettings)
        {
            _requestBuilder = new WeatherRequestBuilder(appSettings);
        }

        public async Task<IEnumerable<ForecastItem>> GetNextFiveDaysWeather(string cityName, Unit unit = Unit.Standard, Language language = Language.en)
        {
            var reqUrl = _requestBuilder.GetForecastUri(cityName, unit, language);
            var forecast = await RestClient.GetAsync<WeatherForecast>(reqUrl);
            var list = forecast.List
                .Select(forecastListItem => new ForecastItem
                {
                    Date = Convertions.UnixTimeStampToDateTime(forecastListItem.LastUpdate).ToString("dd/MM/yyyy"),
                    Temperature = forecastListItem.Main.Temperature,
                    Description = forecastListItem.Weather[0]?.Description
                });

            return list.GroupBy(forecastItem => forecastItem.Date).Select(ForecastItem => ForecastItem.First()).ToArray();
        }
    }
}