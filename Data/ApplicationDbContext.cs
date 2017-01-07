using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AlexWebApp.Models;

namespace AlexWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
     {
          public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
              : base(options)
          {
          }
          public DbSet<Client> clients { get; set; }
          public DbSet<EmailPromo> emailPromos { get; set; }
          public DbSet<Order> orders { get; set; }
          public DbSet<Address> addresses { get; set; }
          protected override void OnModelCreating(ModelBuilder builder)
          {
               base.OnModelCreating(builder);
               // Customize the ASP.NET Identity model and override the defaults if needed.
               // For example, you can rename the ASP.NET Identity table names and more.
               // Add your customizations after calling base.OnModelCreating(builder);
          }
     }
}
