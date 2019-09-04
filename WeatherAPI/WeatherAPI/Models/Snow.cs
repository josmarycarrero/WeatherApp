using Newtonsoft.Json;

namespace WeatherAPI.Models
{
    public class Snow
    {
        /// <summary>
        /// Snow volume for last 3 hours
        /// </summary>
        [JsonProperty("3h")]
        public long VolumeLastThreeHours { get; set; }
    }
}