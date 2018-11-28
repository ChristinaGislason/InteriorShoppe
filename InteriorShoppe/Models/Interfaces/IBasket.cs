using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorShoppe.Models.Interfaces
{
    public interface IBasket
    {
        //Create
        Task CreateBasket(Basket basket);

        //Update
        Task UpdateBasket(Basket basket);

        //Delete
        Task DeleteBasket(int furnitureID);

        //Read
        Task<List<Basket>> GetBasket(string userID);
        Task<Basket> GetFurniture(int? ID);
    }
}
