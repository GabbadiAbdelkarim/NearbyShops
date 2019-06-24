using Microsoft.EntityFrameworkCore;
using NearbyShops.Domain.Models;

namespace NearbyShops.Infrastructure
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Shop> Shops { get; set; }
    }
}
