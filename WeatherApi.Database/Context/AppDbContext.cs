using Microsoft.EntityFrameworkCore;
using WeatherApi.Database.Entities;

namespace WeatherApi.Database;

public class AppDbContext : DbContext
{
  public DbSet<Summary> Summaries { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseNpgsql("Host=postgres;Database=weather_database;Username=docker_user;Password=password");

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Summary>().HasData(
      new Summary() { Id = 1, Description = "Freezing" },
      new Summary() { Id = 2, Description = "Bracing" },
      new Summary() { Id = 3, Description = "Chilly" },
      new Summary() { Id = 4, Description = "Cool" },
      new Summary() { Id = 5, Description = "Mild" },
      new Summary() { Id = 6, Description = "Warm" },
      new Summary() { Id = 7, Description = "Balmy" },
      new Summary() { Id = 8, Description = "Hot" },
      new Summary() { Id = 9, Description = "Sweltering" },
      new Summary() { Id = 10, Description = "Scorching" }
    );
  }
}

