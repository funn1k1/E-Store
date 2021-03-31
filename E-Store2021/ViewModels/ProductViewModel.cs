using E_Store2021.Models;
using System.Collections.Generic;

namespace E_Store2021.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }

        public SubCategory SubCategory { get; set; }

        public Category Category { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }

        public Company Company { get; internal set; }

        public ICollection<Category> Categories { get; set; }
    }
}