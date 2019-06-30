using NearbyShops.Infrastructure;
using NearbyShops.Infrastructure.Entities;
using System.Collections.Generic;
using System.Linq;

namespace NearbyShops.Middle
{
    /// <summary>
    /// ShopMiddleService
    /// </summary>
    public class ShopMiddleService
    {
        /// <summary>
        /// The context
        /// </summary>
        private ShopContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShopMiddleService"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public ShopMiddleService(ShopContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Deletes the preffered shop.
        /// </summary>
        /// <param name="idUser">The identifier user.</param>
        /// <param name="idShop">The identifier shop.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool DeletePrefferedShop(int idUser, int idShop)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Dislikes the shop.
        /// </summary>
        /// <param name="idUser">The identifier user.</param>
        /// <param name="idShop">The identifier shop.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool DislikeShop(int idUser, int idShop)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets the preffered shops.
        /// </summary>
        /// <param name="idUser">The identifier user.</param>
        /// <returns></returns>
        public IEnumerable<Shop> GetPrefferedShops(int idUser)
        {
            return _context.Shops;
        }

        /// <summary>
        /// Gets the shops by distance.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Shop> GetShopsByDistance()
        {
            return _context.Shops;
        }

        /// <summary>
        /// Likes the shop.
        /// </summary>
        /// <param name="idUser">The identifier user.</param>
        /// <param name="idShop">The identifier shop.</param>
        /// <returns></returns>
        public bool LikeShop(int idUser, int idShop)
        {
            //_context.Shops();
            _context.SaveChanges();

            return true;
        }
    }
}
