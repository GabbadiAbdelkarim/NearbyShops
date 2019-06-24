using System;
using System.Collections.Generic;
using System.Text;

namespace NearbyShops.Domain.Models
{
    public class User
    {
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public List<Shop> PrefferedShops { get; set; }
    }
}
