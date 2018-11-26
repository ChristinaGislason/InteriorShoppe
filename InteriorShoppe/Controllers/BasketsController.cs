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

namespace InteriorShoppe.Controllers
{
    public class BasketsController : Controller
    {
        private readonly InteriorShoppeDbContext _context;
        private readonly IBasket _basket;
        private readonly IInventory _inventory;

        // Basket contructor-- brings in code into a class 
        public BasketsController(InteriorShoppeDbContext context, IBasket basket, IInventory inventory)
        {
            _context = context;
            _basket = basket;
            _inventory = inventory;
        }

        // GET: Baskets
        public async Task<IActionResult> Index()
        {
            var InteriorShoppeDbContext = _context.Basket.Include(u => u.user).Include(f => f.furniture);
            return View(await InteriorShoppeDbContext.ToListAsync());
        }

        // GET: Baskets/Details/5
        public async Task<IActionResult> Details(int? basketID, int? furnitureID)
        {
            if (basketID == null || furnitureID == null)
            {
                return NotFound();
            }

            var basket = await _context.Basket
                .Include(u => u.user)
                .FirstOrDefaultAsync(b => b.BasketID == basketID && b.FurnitureID == furnitureID);
            if (basket == null)
            {
                return NotFound();
            }

            return View(basket);
        }

        // GET: Baskets/Create
        public IActionResult Create()
        {
            ViewData["BasketID"] = new SelectList(_context.Basket, "ID", "Name");
            ViewData["FurnitureID"] = new SelectList(_context.Furniture, "ID", "Name");

            return View();
        }

        // POST: Baskets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FurnitureID,Quantity")] Basket basket)
        {
            if (ModelState.IsValid)
            {
                _context.Add(basket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BasketID"] = new SelectList(_context.Basket, "ID", "ID", basket.BasketID);
            ViewData["FurnitureID"] = new SelectList(_context.Furniture, "ID", "ID", basket.FurnitureID);

            return View(basket);
        }

        // GET: Baskets/Edit/5
        public async Task<IActionResult> AddToBasket(int? basketID, int? furnitureID)
        {
            if (basketID == null)
            {
                return NotFound();
            }

            var basket = await _context.Basket.FindAsync(basketID, furnitureID);
            if (basket == null)
            {
                return NotFound();
            }
            ViewData["BasketID"] = new SelectList(_context.Basket, "ID", "ID", basket.BasketID);
            ViewData["FurnitureID"] = new SelectList(_context.Furniture, "ID", "ID", basket.FurnitureID);

            return View(basket);
        }

        // POST: Baskets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int basketID, [Bind("ID,FurnitureID,Quantity")] Basket basket)
        {
            if (basketID != basket.BasketID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(basket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BasketExists(basket.BasketID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            ViewData["BasketID"] = new SelectList(_context.Basket, "ID", "ID", basket.BasketID);
            ViewData["FurnitureID"] = new SelectList(_context.Furniture, "ID", "ID", basket.FurnitureID);

            return View(basket);
        }

        // GET: Baskets/Delete/5
        public async Task<IActionResult> Delete(int? basketID, int? furnitureID)
        {
            if (basketID == null || furnitureID == null)
            {
                return NotFound();
            }

            var basket = await _context.Basket
                .Include(u => u.user)
                .FirstOrDefaultAsync(b => b.BasketID == basketID && b.FurnitureID == furnitureID);

            if (basket == null)
            {
                return NotFound();
            }

            return View(basket);
        }

        // POST: Baskets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int basketID, int furnitureID)
        {
            var basket = await _context.Basket.FindAsync(basketID, furnitureID);
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
