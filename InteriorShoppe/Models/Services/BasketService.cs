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

        public async Task DeleteBasket(int furnitureID)
        {
            Basket basketItem = await GetFurniture(furnitureID);
            _context.Basket.Remove(basketItem);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Basket>> GetBasket(string userID)
        {
            var basketItems = await _context.Basket.Where(b => b.UserID == userID).ToListAsync();
            //basketItems.ForEach(item => item.Furniture =_context.Furniture.Find(item.FurnitureID));
            return basketItems;
        }

        public async Task<Basket> GetFurniture(int? ID)
        {
            return await _context.Basket.FirstOrDefaultAsync(item => item.FurnitureID == ID);
        }

        public async Task UpdateBasket(Basket basket)
        {
            _context.Basket.Update(basket);
            await _context.SaveChangesAsync();
        }

    }
}
