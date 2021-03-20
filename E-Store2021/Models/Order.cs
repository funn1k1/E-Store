using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.Models
{
    public class Order
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string Address { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public int Zip { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public bool IsSave { get; set; }

        public ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }

        public ApplicationUser User { get; set; }
    }
}
