using System;
using WeatherAPI.Helpers;
using Xunit;

namespace WeatherAPI.Test
{
    public class ConvertionsTest
    {
        [Fact]
        public void UnixTimeStampToDateTime()
        {
            DateTime date = Convertions.UnixTimeStampToDateTime(1567695600);
            Assert.Equal("9/5/2019 5:00:00 PM", date.ToString());

        }
    }
}
