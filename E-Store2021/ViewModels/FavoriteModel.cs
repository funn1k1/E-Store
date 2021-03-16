using E_Store2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.ViewModels
{
    public static class FavoriteModel
    {
        public static ICollection<FavoriteItem> FavoriteItems { get; set; }
    }
}
