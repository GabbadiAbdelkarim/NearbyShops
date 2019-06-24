using System;
using System.Collections.Generic;
using System.Text;

namespace NearbyShops.Domain.Models
{
    public class Shop
    {
        public int Id { get; set; }

        public string ShopName { get; set; }

        public string Address { get; set; }

        public int PhoneNumber { get; set; }

        public int ZipCode { get; set; }

        public string Town { get; set; }

        public string Country { get; set; }
    }
}
