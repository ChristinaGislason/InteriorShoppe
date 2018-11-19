using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InteriorShoppe.Models;

namespace InteriorShoppe.Data
{
    public class InteriorShoppeDbContext : DbContext
    {
        public InteriorShoppeDbContext(DbContextOptions<InteriorShoppeDbContext> options) : base(options)
        {

        }
        public DbSet<InteriorShoppe.Models.Furniture> Furniture { get; set; }
    }
}
