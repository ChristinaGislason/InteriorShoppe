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
        public int BasketID { get; set; }

        [Required]
        public int FurnitureID { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        public ApplicationUser user { get; set; }
        public ICollection<Furniture> furniture { get; set; }
    }
}
