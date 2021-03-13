using E_Store2021.Models;
using System.Collections.Generic;

namespace E_Store2021.ViewModels
{
    public class CategoryModel
    {
        public int ID { get; set; }

        public string CategoryName { get; set; }

        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}