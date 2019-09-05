using System;

namespace WeatherAPI.Models
{
    public class ForecastItem
    {

        /// <summary>
        /// date
        /// </summary>
        public String Date { get; set; }

        /// <summary>
        /// Temperature
        /// </summary>
        public double Temperature { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }
    }
}