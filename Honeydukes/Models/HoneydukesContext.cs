using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Honeydukes.Models
{
  public class HoneydukesContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Flavor> Flavor { get; set; }
    public DbSet<Treat> Treat { get; set; }
    public DbSet<FlavorTreat> FlavorTreat { get; set; }

    public HoneydukesContext(DbContextOptions options) : base(options) { }
  }
}