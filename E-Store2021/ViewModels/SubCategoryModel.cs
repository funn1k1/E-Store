using E_Store2021.Models;
using System.Collections.Generic;

namespace E_Store2021.ViewModels
{
    public class SubCategoryModel
    {
        public int ID { get; set; }

        public string SubCategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}