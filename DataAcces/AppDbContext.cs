using Microsoft.EntityFrameworkCore;
using MVCCRUD.Models;

namespace MVCCRUD.DataAcces
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Product>().HasData(
          new Product { Id = 1, Name = "Choy", Price = 500 },
          new Product { Id = 2, Name = "Qurut", Price = 600 },
          new Product { Id = 3, Name = "Shaftoli", Price = 700 },
          new Product { Id = 4, Name = "Daftar", Price = 900 },
          new Product { Id = 5, Name = "Qulupnay", Price = 1000 },
          new Product { Id = 6, Name = "Kundalik", Price = 1100 },
          new Product { Id = 7, Name = "Zaryadchik", Price = 1200 },
          new Product { Id = 8, Name = "Kefir", Price = 1300 },
          new Product { Id = 9, Name = "Moloko", Price = 1400 },
          new Product { Id = 10, Name = "Olma", Price = 1500 },
          new Product { Id = 11, Name = "Guruch", Price = 1600 },
          new Product { Id = 12, Name = "Bolalar kiyimi", Price = 1700 },
          new Product { Id = 13, Name = "Bosma", Price = 1800 },
          new Product { Id = 14, Name = "Non", Price = 1900 },
          new Product { Id = 15, Name = "Sabzi", Price = 2000 },
          new Product { Id = 16, Name = "Gilos", Price = 2100 },
          new Product { Id = 17, Name = "Sut", Price = 2200 },
          new Product { Id = 18, Name = "Dorixona yopiq yog'i", Price = 2300 },
          new Product { Id = 19, Name = "Planshet", Price = 2400 },
          new Product { Id = 20, Name = "Telefon", Price = 2500 },
          new Product { Id = 21, Name = "Oshxona mebellari", Price = 2600 },
          new Product { Id = 22, Name = "Buxanka", Price = 2700 },
          new Product { Id = 23, Name = "Kofe", Price = 2800 },
          new Product { Id = 24, Name = "Pishiriqlar", Price = 2900 },
          new Product { Id = 25, Name = "Ruchka", Price = 3000 },
          new Product { Id = 26, Name = "Yengil telli choy", Price = 3100 },
          new Product { Id = 27, Name = "Shokolad", Price = 3200 },
          new Product { Id = 28, Name = "Plenka", Price = 3300 },
          new Product { Id = 29, Name = "Komp'yuter", Price = 3400 },
          new Product { Id = 30, Name = "Paltar", Price = 3500 },
          new Product { Id = 31, Name = "Disk", Price = 3600 },
          new Product { Id = 32, Name = "Uchqun", Price = 3700 },
          new Product { Id = 33, Name = "Konditsioner", Price = 3800 },
          new Product { Id = 34, Name = "Shampun", Price = 3900 },
          new Product { Id = 35, Name = "Avtomobil", Price = 4000 },
          new Product { Id = 36, Name = "Ovqat", Price = 4100 },
          new Product { Id = 37, Name = "Qush", Price = 4200 },
          new Product { Id = 38, Name = "Muzlatkich", Price = 4300 },
          new Product { Id = 39, Name = "Tarvuz", Price = 4400 },
          new Product { Id = 40, Name = "Mayka", Price = 4500 },
          new Product { Id = 41, Name = "Mevalar", Price = 4600 },
          new Product { Id = 42, Name = "Kapusta", Price = 4700 },
          new Product { Id = 43, Name = "Oshpaz", Price = 4800 },
          new Product { Id = 44, Name = "Pitsa", Price = 4900 },
          new Product { Id = 45, Name = "Yog'och", Price = 5000 },
          new Product { Id = 46, Name = "Futbolka", Price = 5100 },
          new Product { Id = 47, Name = "Shlyapa", Price = 5200 },
          new Product { Id = 48, Name = "Mushak", Price = 5300 },
          new Product { Id = 49, Name = "Tovuq", Price = 5400 },
          new Product { Id = 50, Name = "Moyinka", Price = 5500 });
        }
    }
}
