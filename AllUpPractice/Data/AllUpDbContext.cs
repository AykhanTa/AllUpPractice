using AllUpPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace AllUpPractice.Data
{
    public class AllUpDbContext : DbContext
    {
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public AllUpDbContext(DbContextOptions options) : base(options)
        {
        }


    }
}
