using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InteriorShoppe.Models;
using InteriorShoppe.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InteriorShoppe.Pages.Admin
{
    public class DeleteModel : PageModel
    {
        private readonly IInventory _inventory;

        public DeleteModel(IInventory inventory)
        {
            _inventory = inventory;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Furniture Furniture { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            Furniture furniture = 

            await _inventory.DeleteFurniture(Furniture.ID);
            return RedirectToPage("./Index");
        }
    }
}