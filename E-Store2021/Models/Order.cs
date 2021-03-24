using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        public string Address { get; set; }

        public string Address2 { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public int Zip { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }

        public ApplicationUser User { get; set; }

        public string UserId { get; set; }
    }
}
