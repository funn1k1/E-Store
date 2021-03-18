using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemID { get; set; }

        
        public Product Product { get; set; }

        public int Quantity { get; set; }

        public double TotalPrice { get; set; }
    }
}
