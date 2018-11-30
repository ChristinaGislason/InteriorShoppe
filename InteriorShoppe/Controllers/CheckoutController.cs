using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InteriorShoppe.Data;
using InteriorShoppe.Models;
using InteriorShoppe.Models.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InteriorShoppe.Controllers
{
    public class CheckoutController : Controller
    {
        private InteriorShoppeDbContext _context;
        private UserManager<ApplicationUser> _userManager;
        private readonly IBasket _basket;

        public CheckoutController(UserManager<ApplicationUser> userManager, InteriorShoppeDbContext context, IBasket basket)
        {
            _userManager = userManager;
            _context = context;
            _basket = basket;
        }

        public async Task<IActionResult> Reciept()
        {
            var userID = _userManager.GetUserId(HttpContext.User);
            var basketItems = await _basket.GetBasket(userID);

            return View(basketItems);
        }
    }
}