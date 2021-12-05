namespace WeatherApi.Services;

public interface IWeatherService
{
    IEnumerable<string> GetSummaries();
}
