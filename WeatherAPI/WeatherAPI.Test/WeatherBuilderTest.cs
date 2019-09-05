using Microsoft.Extensions.Options;
using System;
using WeatherAPI.Helpers;
using Xunit;

namespace WeatherAPI.Test
{

    public class WeatherbuilderTest
    {
        

        [Fact]
        public void GetUriStandard()
        {
            var someOptions = GetOptions();

            string baseUrl = "http://api.openweathermap.org/data/2.5/";
            string route = "forecast?appid=aa69195559bd4f88d79f9aadeb77a8f6&q=Barcelona".ToString();
            RestUrl build = new WeatherRequestBuilder(someOptions).GetForecastUri("Barcelona", StandarTypes.Unit.Standard, StandarTypes.Language.en);

            Assert.Equal(build.Base, baseUrl);
            Assert.Equal(build.Route, route);

        }

        [Fact]
        public void GetUriMetric()
        {
            var someOptions = GetOptions();

            string baseUrl = "http://api.openweathermap.org/data/2.5/";
            string route = "forecast?appid=aa69195559bd4f88d79f9aadeb77a8f6&q=Barcelona&units=Metric".ToString();
            RestUrl build = new WeatherRequestBuilder(someOptions).GetForecastUri("Barcelona", StandarTypes.Unit.Metric, StandarTypes.Language.en);

            Assert.Equal(build.Base, baseUrl);
            Assert.Equal(build.Route, route);

        }

        [Fact]
        public void GetUriLanguage()
        {
            var someOptions = GetOptions();

            string baseUrl = "http://api.openweathermap.org/data/2.5/";
            string route = "forecast?appid=aa69195559bd4f88d79f9aadeb77a8f6&q=Barcelona&lang=es".ToString();
            RestUrl build = new WeatherRequestBuilder(someOptions).GetForecastUri("Barcelona", StandarTypes.Unit.Standard, StandarTypes.Language.es);

            Assert.Equal(build.Base, baseUrl);
            Assert.Equal(build.Route, route);

        }

        private IOptions<AppSettings> GetOptions() {

            AppSettings settings = new AppSettings();
            settings.ApiUrl = "http://api.openweathermap.org/data/2.5/";
            settings.AppId = "aa69195559bd4f88d79f9aadeb77a8f6";
            var someOptions = Options.Create(settings);

            return someOptions;
        }
    }
}