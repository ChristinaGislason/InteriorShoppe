using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InteriorShoppe.Data;
using InteriorShoppe.Models;

namespace InteriorShoppe.Controllers
{
    public class ShopController : Controller
    {
        private readonly InteriorShoppeDbContext _context;

        public ShopController(InteriorShoppeDbContext context)
        {
            _context = context;
        }

        // GET: Shop
        public async Task<IActionResult> Index()
        {
            return View(await _context.Furniture.ToListAsync());
        }

        // GET: Shop/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var furniture = await _context.Furniture
                .FirstOrDefaultAsync(m => m.ID == id);
            if (furniture == null)
            {
                return NotFound();
            }

            return View(furniture);
        }

        //// GET: Shop/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Shop/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("ID,SKU,Name,Price,RoomCollection,TypeCollection")] Furniture furniture)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(furniture);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(furniture);
        //}

        //// GET: Shop/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var furniture = await _context.Furniture.FindAsync(id);
        //    if (furniture == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(furniture);
        //}

        //// POST: Shop/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("ID,SKU,Name,Price,RoomCollection,TypeCollection")] Furniture furniture)
        //{
        //    if (id != furniture.ID)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(furniture);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!FurnitureExists(furniture.ID))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(furniture);
        //}

        //// GET: Shop/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var furniture = await _context.Furniture
        //        .FirstOrDefaultAsync(m => m.ID == id);
        //    if (furniture == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(furniture);
        //}

        //// POST: Shop/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var furniture = await _context.Furniture.FindAsync(id);
        //    _context.Furniture.Remove(furniture);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool FurnitureExists(int id)
        //{
        //    return _context.Furniture.Any(e => e.ID == id);
        //}
    }
}
