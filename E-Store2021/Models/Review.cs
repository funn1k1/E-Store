using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Store2021.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public string Text { get; set; }

        public int? ProductID { get; set; }

        public virtual Product Product { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
