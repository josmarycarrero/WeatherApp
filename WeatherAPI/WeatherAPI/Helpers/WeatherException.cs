using System;
using System.Net;
using System.Net.Http;

namespace WeatherAPI.Helpers
{
    public sealed class WeatherException : Exception
    {
        /// <summary>
        /// The response message
        /// </summary>
        public HttpResponseMessage ResponseMessage { get; set; }

        /// <summary>
        /// The status code
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="statusCode">The status code</param>
        internal WeatherException(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="responseMessage">The response message</param>
        internal WeatherException(HttpResponseMessage responseMessage)
        {
            ResponseMessage = responseMessage;
        }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="e">The exception</param>
        internal WeatherException(Exception e) : base("OpenWeatherMap error", e)
        {
        }
    }
}