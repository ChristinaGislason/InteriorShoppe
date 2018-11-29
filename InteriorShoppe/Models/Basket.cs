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

        public string UserID { get; set; }

        public int FurnitureID { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }
        
        public List<Furniture> Furniture { get; set; }
    }
}
