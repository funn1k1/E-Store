using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.Models
{
    public class User: IdentityUser
    {
        public int UserID { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Gender { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
