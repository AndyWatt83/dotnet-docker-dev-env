using WeatherApi.Database;

namespace WeatherApi.Services;
public class WeatherService : IWeatherService
{
  private readonly AppDbContext _appDbContext;

  public WeatherService(AppDbContext appDbContext)
  {
    _appDbContext = appDbContext;
  }

  public IEnumerable<string> GetSummaries()
  {
    return _appDbContext.Summaries.Select(summary => summary.Description);
  }
}