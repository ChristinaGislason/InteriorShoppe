using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InteriorShoppe.Data;
using InteriorShoppe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace InteriorShoppe.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private InteriorShoppeDbContext _context;

        public IndexModel(InteriorShoppeDbContext context)
        {
            _context = context;
        }

        public List<Furniture> Furnitures { get; set; }

        public async Task OnGet()
        {
            Furnitures = await _context.Furniture.ToListAsync();
        }
    }
}