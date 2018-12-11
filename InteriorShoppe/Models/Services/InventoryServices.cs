using InteriorShoppe.Models.Interfaces;
using InteriorShoppe.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorShoppe.Models.Services
{
    public class InventoryServices : IInventory
    {
        private InteriorShoppeDbContext _context { get; set; }

        public InventoryServices(InteriorShoppeDbContext context)
        {
            _context = context;
        }

        public async Task CreateFurniture(Furniture furniture)
        {
            _context.Add(furniture);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFurniture(int? id)
        {
            Furniture furniture = await _context.Furniture.FindAsync(id);
            _context.Remove(furniture);
            await _context.SaveChangesAsync();
        }

        public Task<List<Furniture>> GetAllFurniture()
        {
            throw new NotImplementedException();
        }

        public async Task<Furniture> GetFurnitureByID(int? id)
        {
            return await _context.Furniture.FindAsync(id);
        }

        public async Task UpdateFurniture(Furniture furniture)
        {
            _context.Furniture.Update(furniture);
            await _context.SaveChangesAsync();
        }
    }
}
