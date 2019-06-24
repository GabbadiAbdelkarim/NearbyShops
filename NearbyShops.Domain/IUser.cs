using NearbyShops.Domain.Models;
using System.Collections.Generic;

namespace NearbyShops.Domain
{
    public interface IUser
    {
        bool SignUp(string login, string password);

        bool SignIn(string login, string password);

        IEnumerable<Shop> GetShopsByDistance();

        bool LikeShop(int idUser, int idShop);

        bool DislikeShop(int idUser, int idShop);

        IEnumerable<Shop> GetPrefferedShops(int idUser);

        bool DeletePrefferedShop(int idUser, int idShop);
    }
}
