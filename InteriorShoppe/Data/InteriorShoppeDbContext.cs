using InteriorShoppe.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorShoppe.Data
{
    public class InteriorShoppeDbContext : DbContext
    {
        public InteriorShoppeDbContext(DbContextOptions<InteriorShoppeDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Furniture>().HasKey(
                ce => new { ce.ID}
            );

            mb.Entity<Furniture>().HasData(
                new Furniture
                {
                    ID = 1,
                    SKU = 100100,
                    Name = "Heather",
                    Price = 2550,
                    RoomCollection = "Living",
                    TypeCollection = "In Stock",
                    Image = "https://images-na.ssl-images-amazon.com/images/I/816d2dCTdQL._SX425_.jpg"

                },
              
    }
}
