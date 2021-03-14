using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.Models
{
    public class Checkout
    {
        public string CardName { get; set; }

        public string CreditCardNumber { get; set; }

        public DateTime ExpirationDate { get; set; }

        public int CVV { get; set; }
    }
}
