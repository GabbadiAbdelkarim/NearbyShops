using Microsoft.EntityFrameworkCore;
using NearbyShops.Infrastructure.Entities;

namespace NearbyShops.Infrastructure
{
    /// <summary>
    /// ShopContext
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class ShopContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopContext"/> class.
        /// </summary>
        /// <param name="options">The options for this context.</param>
        public ShopContext(DbContextOptions options) : base(options) { }

        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        /// <value>
        /// The users.
        /// </value>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Gets or sets the shops.
        /// </summary>
        /// <value>
        /// The shops.
        /// </value>
        public DbSet<Shop> Shops { get; set; }
    }
}
