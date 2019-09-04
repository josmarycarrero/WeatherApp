using Newtonsoft.Json;

namespace WeatherAPI.Models
{
    public class Rain
    {
        /// <summary>
        /// Rain volume for last 3 hours, mm
        /// </summary>
        [JsonProperty("3h")]
        public double VolumeLastThreeHours { get; set; }
    }
}
