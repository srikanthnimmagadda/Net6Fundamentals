using Microsoft.EntityFrameworkCore;

namespace Net6Fundamentals.Models
{
    public class ShopDbContext: DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Pie> Pies { get; set; }
    }
}
