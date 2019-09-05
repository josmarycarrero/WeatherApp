using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeatherAPI.Models

{
    public class WeatherForecast
    {
        /// <summary>
        /// The city
        /// </summary>
        [JsonProperty("city")]
        public City City { get; set; }

        /// <summary>
        /// The list of Forecast Items
        /// </summary>
        [JsonProperty("list")]
        public List<WeatherItem> List { get; set; }
    }
}