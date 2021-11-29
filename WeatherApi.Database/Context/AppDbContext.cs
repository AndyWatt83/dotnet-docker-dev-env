using Microsoft.EntityFrameworkCore;
using WeatherApi.Database.Entities;

namespace WeatherApi.Database
{
  public class AppDbContext : DbContext
  {
    public DbSet<Summary> Summaries { get; set; }

    public string DbPath { get; private set; }

    public AppDbContext()
    {
      var folder = Environment.SpecialFolder.LocalApplicationData;
      var path = Environment.GetFolderPath(folder);
      DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}blogging.db";
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
  }
}