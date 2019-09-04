using Newtonsoft.Json;

namespace WeatherAPI.Models
{
    public class Clouds
    {
        /// <summary>
        /// Cloudiness, %
        /// </summary>
        [JsonProperty("all")]
        public int CloudinessPercentage { get; set; }
    }
}
