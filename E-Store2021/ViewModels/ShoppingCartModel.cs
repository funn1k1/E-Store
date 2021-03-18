using System.Collections.Generic;

namespace E_Store2021.Models
{
    public static class ShoppingCartModel
    {
        public static double? Total { get; set; }

        public static int? Count { get; set; }
        public static ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}