using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherAPI.Models.Enums;

namespace WeatherAPI.Helpers
{
    public abstract class ClientBase
    {

        /// <summary>
        /// The Http Client to send requests to Openweathermap
        /// </summary>
        private HttpClient HttpClient { get; set; }

        /// <summary>
        /// The api key
        /// </summary>
        private string ApiKey { get; set; }

        /// <summary>
        /// The Openweathermap URL
        /// </summary>
        protected string OpenWeatherMapUrl { get; set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="apiKey">The api key</param>
        /// <param name="openWeatherMapUrl">The Openweathermap URL</param>
        protected ClientBase(string apiKey, string openWeatherMapUrl)
        {
            ApiKey = apiKey;
            OpenWeatherMapUrl = openWeatherMapUrl;
            CreateHttpClient();
        }


        /// <summary>
        /// Creates the HTTP Client
        /// </summary>
        private void CreateHttpClient()
        {
            HttpClient = new HttpClient
            {
                BaseAddress = new Uri(OpenWeatherMapUrl)
            };
        }


        /// <summary>
        /// Makes a GET request to the provided URL
        /// </summary>
        /// <param name="url">The URL</param>
        /// <returns>A HTTP response message object</returns>
        /// <exception cref="OpenWeatherMapException">
        ///     Thrown when something got wrong making the GET request
        /// </exception>
        private HttpResponseMessage GetRequest(string url)
        {
            HttpResponseMessage response = HttpClient.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            else
            {
                throw new WeatherException(response);
            }
        }
    }
}
