using System;
using Xunit;
using TestWebApi;
using TestWebApi.Controllers;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace WebApi.Tests
{
    public class UnitTest1
    {
        private static ILogger<WeatherForecastController> _logger;
        WeatherForecastController controller = new WeatherForecastController(_logger);
        [Fact]
        public void ForecastTest()
        {
        var okResult = controller.Get();
 
        Assert.IsType<WeatherForecast[]>(okResult);
        }

        [Fact]
        public void ForecastIsUpdated()
        {    
        WeatherForecast[] result = controller.Get() as WeatherForecast[];
        Assert.Equal(result.Length, 5);
        }
  }
}
