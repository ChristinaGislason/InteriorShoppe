using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using InteriorShoppe.Data;
using InteriorShoppe.Models;
using InteriorShoppe.Models.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
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

        /// <summary>
        /// Generates user invoice
        /// </summary>
        /// <returns>Receipt View</returns>
        public async Task<IActionResult> Receipt()
        {
            var user = HttpContext.User;
            var userID = _userManager.GetUserId(user);
            var basketItems = await _basket.GetBasket(userID);

            return View(basketItems);
        }
    }
}