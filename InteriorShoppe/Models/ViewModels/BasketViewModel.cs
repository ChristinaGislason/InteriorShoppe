using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorShoppe.Models.ViewModels
{
    public class BasketViewModel
    {
        public int BasketID { get; set; }

        public string UserID { get; set; } 

        public int Quantity { get; set; }

        public Furniture Furniture { get; set; }
    }
}
