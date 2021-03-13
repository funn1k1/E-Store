using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.Models.StaticModels
{
    public static class SelectBox
    {
        public static IEnumerable<SelectListItem> Categories { get; set; }

        public static IEnumerable<SelectListItem> SubCategories { get; set; }
    }
}
