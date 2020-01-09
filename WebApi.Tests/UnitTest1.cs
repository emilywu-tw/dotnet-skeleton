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
        private readonly ILogger<WeatherForecastController> _logger;
        
        [Fact]
        public void Test1()
        {
            Assert.True(true);
            Assert.False(false);
        }

        [Fact]
        public void ForecastTest()
        {
        WeatherForecastController controller = new WeatherForecastController(_logger);
    
        var okResult = controller.Get();
 
        Assert.IsType<WeatherForecast[]>(okResult);
        }
    }
}
