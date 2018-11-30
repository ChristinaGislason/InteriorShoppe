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

        /// <summary>
        /// Deletes item from basket
        /// </summary>
        /// <param name="furnitureID">ID of Furniture to remove</param>
        /// <returns>Saves Changes</returns>
        public async Task DeleteBasket(int furnitureID)
        {
            Basket basketItem = await GetFurniture(furnitureID);
            _context.Basket.Remove(basketItem);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Gets Basket by the user's ID
        /// </summary>
        /// <param name="userID">User's ID</param>
        /// <returns>Basket</returns>
        public async Task<List<Basket>> GetBasket(string userID)
        {
            var basketItems = await _context.Basket.Where(b => b.UserID == userID).ToListAsync();
            basketItems.ForEach(item => item.Furniture = _context.Furniture.Find(item.FurnitureID));
            return basketItems;
        }

        /// <summary>
        /// Gets a specific item out of a basket
        /// </summary>
        /// <param name="basketID">Basket ID</param>
        /// <returns>Basket Item</returns>
        public async Task<Basket> GetBasketItem(int? basketID)
        {
            var basketItem = await _context.Basket.FirstOrDefaultAsync(item => item.BasketID == basketID);
            basketItem.Furniture = _context.Furniture.Find(basketItem.FurnitureID);
            return basketItem;
        }

        /// <summary>
        /// Gets the furniture by id out of a basket
        /// </summary>
        /// <param name="ID">Furniture ID</param>
        /// <returns>Furniture Item</returns>
        public async Task<Basket> GetFurniture(int? ID)
        {
            return await _context.Basket.FirstOrDefaultAsync(item => item.FurnitureID == ID);
        }

        /// <summary>
        /// Updates a basket with any changes
        /// </summary>
        /// <param name="basket">Basket to be Updated</param>
        /// <returns>Saves Changes</returns>
        public async Task UpdateBasket(Basket basket)
        {
            _context.Basket.Update(basket);
            await _context.SaveChangesAsync();
        }

    }
}
