using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Store2021.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        public string ImagePath { get; set; }

        [Display(Name = "Category Description")]
        public string Description { get; set; }

        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}