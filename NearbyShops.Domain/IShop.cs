using NearbyShops.Domain.Models;
using System.Collections.Generic;

namespace NearbyShops.Domain
{
    /// <summary>
    /// Shop interface
    /// </summary>
    public interface IShop
    {
        /// <summary>
        /// Gets the shops by distance.
        /// </summary>
        IEnumerable<Shop> GetShopsByDistance();

        /// <summary>
        /// Likes the shop.
        /// </summary>
        /// <param name="idUser">The identifier user.</param>
        /// <param name="idShop">The identifier shop.</param>
        bool LikeShop(int idUser, int idShop);

        /// <summary>
        /// Dislikes the shop.
        /// </summary>
        /// <param name="idUser">The identifier user.</param>
        /// <param name="idShop">The identifier shop.</param>
        bool DislikeShop(int idUser, int idShop);

        /// <summary>
        /// Gets the preffered shops.
        /// </summary>
        /// <param name="idUser">The identifier user.</param>
        IEnumerable<Shop> GetPrefferedShops(int idUser);

        /// <summary>
        /// Deletes the preffered shop.
        /// </summary>
        /// <param name="idUser">The identifier user.</param>
        /// <param name="idShop">The identifier shop.</param>
        /// <returns></returns>
        bool DeletePrefferedShop(int idUser, int idShop);
    }
}
