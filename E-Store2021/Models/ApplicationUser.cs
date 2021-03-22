using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public byte[] ProfilePicture { get; set; }

        public int UsernameChangeLimit { get; set; } = 10;

        public string Phone { get; set; }

        public string Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Coupon> Coupons { get; set; }
    }
}
