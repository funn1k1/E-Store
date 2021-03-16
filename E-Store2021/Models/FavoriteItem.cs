using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.Models
{
    public class FavoriteItem
    {
        public int FavoriteItemID { get; set; }

        public Product Product { get; set; }

        public int? ShoppingCartID { get; set; }
    }
}
