using WeatherApi.Database;
using WeatherApi.Database.Entities;

namespace WeatherApi.Services;

public class WeatherService
{
  private readonly AppDbContext _appDbContext;

  public WeatherService(AppDbContext appDbContext)
  {
    _appDbContext = appDbContext;
  }

  public IEnumerable<Summary> GetSummaries()
  {
        return null;
  }
}