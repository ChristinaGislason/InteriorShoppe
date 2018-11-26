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
        Task DeleteBasket(int ID);

        //Read
        Task<Basket> GetBasket(int? id);
        Task<List<Furniture>> GetFurniture(int? id);
    }
}
