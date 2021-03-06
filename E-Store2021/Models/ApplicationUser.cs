using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Store2021.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Profile Picture")]
        public byte[] ProfilePicture { get; set; }

        public int UsernameChangeLimit { get; set; } = 10;

        public string Phone { get; set; }

        public string Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Coupon> Coupons { get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}
