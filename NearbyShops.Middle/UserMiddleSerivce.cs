using System.Collections.Generic;
using System.Linq;
using NearbyShops.Domain;
using NearbyShops.Domain.Models;
using NearbyShops.Infrastructure;

namespace NearbyShops.Middle
{
    public class UserMiddleSerivce : IUser
    {
        private ShopContext _context;

        public UserMiddleSerivce(ShopContext context)
        {
            _context = context;
        }

        public bool DeletePrefferedShop(int idUser, int idShop)
        {
            throw new System.NotImplementedException();
        }

        public bool DislikeShop(int idUser, int idShop)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Shop> GetPrefferedShops(int idUser)
        {
            return _context.Shops;
        }

        public IEnumerable<Shop> GetShopsByDistance()
        {
            return _context.Shops;
        }

        public bool LikeShop(int idUser, int idShop)
        {
            _context.Users
                .FirstOrDefault(o => o.UserId == idUser)
                .PrefferedShops.Add(new Shop());
            _context.SaveChanges();

            return true;
        }

        public bool SignIn(string login, string password)
        {
            throw new System.NotImplementedException();
        }

        public bool SignUp(string login, string password)
        {
            _context.Add(new User(login, password));
            _context.SaveChanges();

            return true;
        }
    }
}
