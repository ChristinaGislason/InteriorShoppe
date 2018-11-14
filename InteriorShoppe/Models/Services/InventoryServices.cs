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
        public Task CreateFurniture(Furniture furniture)
        {
            throw new NotImplementedException();
        }

        public Task DeleteFurniture(Furniture furniture)
        {
            throw new NotImplementedException();
        }

        public Task<List<Furniture>> GetAllFurniture()
        {
            throw new NotImplementedException();
        }

        public Task<Furniture> GetFurnitureByID(int? id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateFurniture(Furniture furniture)
        {
            throw new NotImplementedException();
        }
    }
}
