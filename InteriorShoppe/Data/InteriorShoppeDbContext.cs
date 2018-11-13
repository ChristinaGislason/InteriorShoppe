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
    }
}
