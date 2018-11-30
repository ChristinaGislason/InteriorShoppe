using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InteriorShoppe.Data;
using InteriorShoppe.Models;
using InteriorShoppe.Models.Interfaces;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace InteriorShoppe.Controllers
{
    [Authorize]
    public class BasketsController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private readonly InteriorShoppeDbContext _context;
        private readonly IBasket _basket;
        private readonly IInventory _inventory;

        // Basket constructor with dependencies
        public BasketsController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, InteriorShoppeDbContext context, IBasket basket, IInventory inventory)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _basket = basket;
            _inventory = inventory;
        }

        // GET: Baskets
        public async Task<IActionResult> Index()
        {
            var userID = _userManager.GetUserId(HttpContext.User);
            var basketItems = await _basket.GetBasket(userID);
            return View(basketItems);
        }
        // GET: Baskets/Edit/5
        public async Task<IActionResult> AddToBasket(int ID)
        {
        
            // Get the user
            var userEmail = User.FindFirst(email => email.Type == ClaimTypes.Email);
            var userID = _userManager.GetUserId(HttpContext.User);
            
            // Get the basket
            Basket basketItem = await _basket.GetFurniture(ID);

            if(basketItem != null)
            {
                basketItem.Quantity += 1;
                await _basket.UpdateBasket(basketItem);
            }
            else
            {
                basketItem = new Basket()
                {
                    UserID = userID,
                    FurnitureID = ID,
                    Quantity = 1
                };
                await _basket.CreateBasket(basketItem);
            }

            return RedirectToAction(nameof(Index), "Shop");
        }

        // GET: Hotels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var basket = await _basket.GetBasketItem(id);
            if (basket == null)
            {
                return NotFound();
            }

            ViewData["BasketID"] = new SelectList(_context.Basket, "ID", "ID", basket.BasketID);

            return View(basket);
        }

        // POST: Baskets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int BasketID, [Bind("BasketID,FurnitureID,Quantity, UserID")] Basket basket)
        {
            

            if (ModelState.IsValid)
            {
                await _basket.UpdateBasket(basket);

                if (!BasketExists(basket.BasketID))
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }

            ViewData["BasketID"] = new SelectList(_context.Basket, "ID", "ID", basket.BasketID);
            ViewData["FurnitureID"] = new SelectList(_context.Furniture, "Name", "ID", basket.FurnitureID);

            return View(basket);
        }

        
        // POST: Baskets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int basketID, int furnitureID)
        {
            var basket = await _context.Basket.FirstOrDefaultAsync(item => item.BasketID == basketID && item.FurnitureID == furnitureID);
            _context.Basket.Remove(basket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BasketExists(int id)
        {
            return _context.Basket.Any(e => e.BasketID == id);
        }
    }
}
