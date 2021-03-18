using System.Collections.Generic;

namespace E_Store2021.Models
{
    public static class ShoppingCartModel
    {
        public static decimal? Total { get; set; }

        public static int? Count { get; set; }
        public static ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}