using System;
using WeatherAPI.StandarTypes;
using System.Text;
using Microsoft.Extensions.Options;

namespace WeatherAPI.Helpers
{
 
    public class WeatherRequestBuilder
    {
        private IOptions<AppSettings> _appSettings;

        public WeatherRequestBuilder(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings;
        }

        public RestUrl GetForecastUri(string cityName, Unit unit = Unit.Standard, Language language = Language.en)
        {
            if (string.IsNullOrWhiteSpace(cityName))
            {
                throw new Exception("City not found");
            }
            var req = new StringBuilder($"forecast?appid={_appSettings.Value.AppId}&q={cityName}");
            if (unit != Unit.Standard)
            {
                req.Append($"&units={unit}");
            }
            if (language != Language.en)
            {
                req.Append($"&lang={language}");
            }

            return new RestUrl { Base = _appSettings.Value.ApiUrl, Route = req.ToString() };
        }
    }
}