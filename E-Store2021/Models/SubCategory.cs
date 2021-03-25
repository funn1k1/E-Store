using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Store2021.Models
{
    public class SubCategory
    {
        public int SubCategoryID { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "SubCategory Name")]
        public string SubCategoryName { get; set; }

        [Display(Name = "SubCategory Description")]

        public string Description { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}