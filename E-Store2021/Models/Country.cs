using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Store2021.Models
{
    public class Country
    {

        public int CountryID { get; set; }

        [Display(Name = "Country Name")]
        public string CountryName { get; set; }

        public virtual ICollection<Company> Companies { get; set; }

    }
}
