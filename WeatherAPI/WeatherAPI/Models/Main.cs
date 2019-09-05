
using Newtonsoft.Json;

namespace WeatherAPI.Models
{
    public class Main
    {
        /// <summary>
        /// Temperature. Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit
        /// </summary>
        [JsonProperty("temp")]
        public double Temperature { get; set; }

        /// <summary>
        /// Atmospheric pressure on the sea level by default, hPa
        /// </summary>
        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        /// <summary>
        /// Humidity, %
        /// </summary>
        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        /// <summary>
        /// Maximum temperature at the moment of calculation
        /// </summary>
        [JsonProperty("temp_max")]
        public double TemperatureMax { get; set; }

        /// <summary>
        /// Minimum temperature at the moment of calculation
        /// </summary>
        [JsonProperty("temp_min")]
        public double TemperatureMin { get; set; }

        /// <summary>
        /// Atmospheric pressure on the sea level, hPa
        /// </summary>
        [JsonProperty("sea_level")]
        public double PressureSeaLevel { get; set; }

        /// <summary>
        /// Atmospheric pressure on the ground level, hPa
        /// </summary>
        [JsonProperty("grnd_level")]
        public double PressureGroundLevel { get; set; }
    }
}