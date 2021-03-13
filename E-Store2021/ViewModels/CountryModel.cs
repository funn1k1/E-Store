using E_Store2021.Models;
using System.Collections.Generic;

namespace E_Store2021.ViewModels
{
    public class CountryModel
    {
        public int ID { get; set; }

        public string CountryName { get; set; }

        public virtual ICollection<Company> Companies { get; set; }

        public bool IsChecked { get; set; }
    }
}