using InteriorShoppe.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorShoppe.Models.Components
{
    public class BasketComponent : ViewComponent
    {
        private InteriorShoppeDbContext _context;
        private UserManager<ApplicationUser> _userManager;

        public BasketComponent(InteriorShoppeDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        /// <summary>
        /// Finds basket associated with the currently logged in user
        /// </summary>
        /// <returns>View and passes list of furrniture in the basket</returns>
        public IViewComponentResult Invoke()
        {
            var user = HttpContext.User; //
            var userId = _userManager.GetUserId(user);
            var basket = _context.Basket.Where(b => b.user.Id == userId)
                .ToList();
            return View(basket);
        }
    }
}
