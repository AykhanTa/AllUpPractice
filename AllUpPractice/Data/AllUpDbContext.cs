using AllUpPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace AllUpPractice.Data
{
    public class AllUpDbContext : DbContext
    {
        public DbSet<Setting> Settings { get; set; }
        public AllUpDbContext(DbContextOptions options) : base(options)
        {
        }


    }
}
