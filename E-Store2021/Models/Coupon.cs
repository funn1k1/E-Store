using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.Models
{
    public class Coupon
    {
        public int CouponID { get; set; }

        public double Discount { get; set; }

        public DateTime ExpirationDate { get; set; }

        public ApplicationUser User { get; set; }

        public string ApplicationUserId { get; set; }

    }
}
