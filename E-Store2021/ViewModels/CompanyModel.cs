using E_Store2021.Models;
using System.Collections.Generic;

namespace E_Store2021.ViewModels
{
    public class CompanyModel
    {
        public int ID { get; set; }

        public string CompanyName { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public bool IsChecked { get; set; }
    }
}