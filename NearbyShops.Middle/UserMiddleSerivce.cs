using NearbyShops.Domain;
using NearbyShops.Domain.Models;
using NearbyShops.Infrastructure;
using System.Linq;

namespace NearbyShops.Middle
{
    /// <summary>
    /// User Middle Serivce
    /// </summary>
    /// <seealso cref="NearbyShops.Domain.IUserMiddleService" />
    public class UserMiddleSerivce : IUserMiddleService
    {
        private ShopContext _context;

        public UserMiddleSerivce(ShopContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Signs in.
        /// </summary>
        /// <param name="login">The login.</param>
        /// <param name="password">The password.</param>
        public bool SignIn(string login, string password)
        {
            return _context.Users.Where(u => u.Login == login && u.Password == password).Any() == true;
        }

        /// <summary>
        /// Signs up.
        /// </summary>
        /// <param name="login">The login.</param>
        /// <param name="password">The password.</param>
        public bool SignUp(string login, string password)
        {
            _context.Add(new User(login, password));
            _context.SaveChanges();

            return true;
        }
    }
}
