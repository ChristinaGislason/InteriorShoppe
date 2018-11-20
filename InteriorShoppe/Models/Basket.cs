using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorShoppe.Models
{
    public class Basket
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int BasketID { get; set; }

        [Required]
        public int ProductID { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }
    }
}
