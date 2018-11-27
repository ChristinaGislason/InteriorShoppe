using InteriorShoppe.Data;
using InteriorShoppe.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorShoppe.Models.Services
{
    public class BasketService : IBasket
    {
        //create database connection
        private InteriorShoppeDbContext _context;
        public BasketService(InteriorShoppeDbContext context)
        {
            _context = context;
        }

        //create basket and add it to the database then save changes
        public async Task CreateBasket(Basket basket)
        {
            _context.Basket.Add(basket);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBasket(int ID)
        {
            Basket basket = await GetBasket(ID);
            _context.Basket.Remove(basket);
            await _context.SaveChangesAsync();
        }

        public async Task<Basket> GetBasket(int? ID)
        {
            return await _context.Basket.FirstOrDefaultAsync(b => b.BasketID == ID);
        }

        public async Task<List<Furniture>> GetFurniture(int? ID)
        {
            return await _context.Furniture.ToListAsync();
        }

        public async Task UpdateBasket(Basket basket)
        {
            _context.Basket.Update(basket);
            await _context.SaveChangesAsync();
        }

    }
}
