using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCCRUD.Models;

namespace MVCCRUD.DataAcces
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUserLogin<string>>()
                .HasKey(l => new { l.LoginProvider, l.ProviderKey });
         //   modelBuilder.Entity<Product>().HasData(
          //new Product { Id = Guid.NewGuid(), Name = "Choy", Price = 500 },
          //new Product { Id = Guid.NewGuid(), Name = "Qurut", Price = 600 },
          //new Product { Id = Guid.NewGuid(), Name = "Shaftoli", Price = 700 },
          //new Product { Id = Guid.NewGuid(), Name = "Daftar", Price = 900 },
          //new Product { Id = Guid.NewGuid(), Name = "Qulupnay", Price = 1000 },
          //new Product { Id = Guid.NewGuid(), Name = "Kundalik", Price = 1100 },
          //new Product { Id = Guid.NewGuid(), Name = "Zaryadchik", Price = 1200 },
          //new Product { Id = Guid.NewGuid(), Name = "Kefir", Price = 1300 },
          //new Product { Id = Guid.NewGuid(), Name = "Moloko", Price = 1400 },
          //new Product { Id = Guid.NewGuid(), Name = "Olma", Price = 1500 },
          //new Product { Id = Guid.NewGuid(), Name = "Guruch", Price = 1600 },
          //new Product { Id = Guid.NewGuid(), Name = "Bolalar kiyimi", Price = 1700 },
          //new Product { Id = Guid.NewGuid(), Name = "Bosma", Price = 1800 },
          //new Product { Id = Guid.NewGuid(), Name = "Non", Price = 1900 });
         
        }
    }
}
