using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Honeydukes.Models
{
  public class HoneydukesContextFactory : IDesignTimeDbContextFactory<HoneydukesContext>
  {

    HoneydukesContext IDesignTimeDbContextFactory<HoneydukesContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<HoneydukesContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new HoneydukesContext(builder.Options);
    }
  }
}