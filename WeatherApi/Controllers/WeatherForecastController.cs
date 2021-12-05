using Microsoft.AspNetCore.Mvc;
using WeatherApi.Services;

namespace WeatherApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
  private static readonly string[] Summaries = new[]
  {
        "111", "222", "333", "444", "555", "666", "777", "888", "999", "000"
    };

  private readonly ILogger<WeatherForecastController> _logger;
  private readonly IWeatherService _service;

  public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherService service)
  {
    _logger = logger;
    _service = service;
  }

  [HttpGet(Name = "GetWeatherForecast")]
  public IEnumerable<WeatherForecast> Get()
  {
    var summaries = _service.GetSummaries().ToArray();
    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
    {
      Date = DateTime.Now.AddDays(index),
      TemperatureC = Random.Shared.Next(-20, 55),
      Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    })
    .ToArray();
  }
}
