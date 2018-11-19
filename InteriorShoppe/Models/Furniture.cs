using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorShoppe.Models
{
    public class Furniture
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Product SKU")]
        public int SKU { get; set; }

        [Required]
        [Display(Name = "Furniture Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Room Collection")]
        public string RoomCollection { get; set; }

        [Display(Name = "Type")]
        public string TypeCollection { get; set; }
    }
}
