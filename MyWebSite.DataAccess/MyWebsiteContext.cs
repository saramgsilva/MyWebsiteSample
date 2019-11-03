using Microsoft.EntityFrameworkCore;
using MyWesite.Model;

namespace MyWebSite.DataAccess
{
    public class MyWebsiteContext : DbContext
    {
        public MyWebsiteContext(DbContextOptions<MyWebsiteContext> options)
        : base(options)
        { }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherForecast>()
                        .HasKey(c => c.Id);
        }
    }
}