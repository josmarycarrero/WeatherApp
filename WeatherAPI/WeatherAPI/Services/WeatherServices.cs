using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WeatherAPI.Interfaces;
using WeatherAPI.Models;
using WeatherAPI.Models.Enums;


namespace WeatherAPI.Services
{
    public class WeatherServices : IWeatherServices
    {

        public async Task<WeatherForecast> GetNextFiveDaysWeather(string cityName, Unit unit = Unit.Standard, Language language = Language.en)
        {
            try
            {
                string urlService = "http://api.openweathermap.org/data/2.5/";
                WeatherForecast result = new WeatherForecast();

                if (string.IsNullOrEmpty(urlService))
                    throw new Exception("Url for Import Invoices not found.");

                using (var _httpClient = new HttpClient())
                {
                    _httpClient.BaseAddress = new Uri(urlService);
                    _httpClient.Timeout = new TimeSpan(0, 0, 30);
                    _httpClient.DefaultRequestHeaders.Clear();


                    var request = new HttpRequestMessage(HttpMethod.Get, "forecast?q=Barcelona,es&units=metric&APPID=0eb550209edec90a152b164d8ad2df33");
                    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var response = await _httpClient.SendAsync(request);

                    response.EnsureSuccessStatusCode();

                    var content = await response.Content.ReadAsStringAsync();

                    result = JsonConvert.DeserializeObject<WeatherForecast>(content);

                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
