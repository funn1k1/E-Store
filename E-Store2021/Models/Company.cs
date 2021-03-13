using System.Collections.Generic;


namespace E_Store2021.Models
{
    public class Company
    {
        public int CompanyID { get; set; }

        public string CompanyName { get; set; }

        public int Year { get; set; }

        public int? CountryID { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
