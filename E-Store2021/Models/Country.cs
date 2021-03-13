using System.Collections.Generic;

namespace E_Store2021.Models
{
    public class Country
    {

        public int CountryID { get; set; }

        public string CountryName { get; set; }

        public virtual ICollection<Company> Companies { get; set; }

    }
}
