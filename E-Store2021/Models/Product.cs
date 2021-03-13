using E_Store2021.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required]
        [StringLength(100)] 
        [Display(Name = "Name")]
        public string ProductName { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        [Display(Name = "Price")]
        public double UnitPrice { get; set; }

        public bool OnSale { get; set; }

        public double Star { get; set; }

        public int Quantity { get; set; }

        public double Discount { get; set; }

        public int? SubCategoryID { get; set; }

        public int? CompanyID { get; set; }

        public virtual Company Company { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public virtual SubCategory SubCategory { get; set; }
    }
}
