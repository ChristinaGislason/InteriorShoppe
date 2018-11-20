using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorShoppe.Models
{
    public class Order
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int BasketID { get; set; }

        [Required]
        public string ApplicationUserID { get; set; }

        public ApplicationUser user { get; set; }
        public Basket basket { get; set; }

    }
}
