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
                ce => new { ce.ID }
            );

            mb.Entity<Furniture>().HasData(
                new Furniture
                {
                    ID = 1,
                    SKU = 100100,
                    Name = "Heather",
                    Price = 2550,
                    RoomCollection = "Living",
                    TypeCollection = "Couch",
                    Image = "https://joybird2.imgix.net/image_1054_109.jpg?"
                },
                new Furniture
                {
                    ID = 2,
                    SKU = 100200,
                    Name = "Elliot",
                    Price = 1850,
                    RoomCollection = "Living",
                    TypeCollection = "Couch",
                    Image = "https://images-na.ssl-images-amazon.com/images/I/816d2dCTdQL._SX425_.jpg"
                },
                new Furniture
                {
                    ID = 3,
                    SKU = 100300,
                    Name = "Henry",
                    Price = 1690,
                    RoomCollection = "Living",
                    TypeCollection = "Couch Set",
                    Image = "https://cdn.shopify.com/s/files/1/1811/5643/products/BBT8013-Black_203pc_20Set-1_8b7e879b-43cb-48e6-9e98-321c13411265_1400x.jpg?v=1507179360"
                },
                new Furniture
                {
                    ID = 4,
                    SKU = 200100,
                    Name = "Preston",
                    Price = 220,
                    RoomCollection = "Dining",
                    TypeCollection = "Dining Chair",
                    Image = "https://cdn.shopify.com/s/files/1/0819/6713/products/4747mid-century-modern-dining-chairs-aqua_5319e712-12fa-4d84-b404-8fb0ccbdfb29_large.jpg?v=1472838603"
                },
                new Furniture
                {
                    ID = 5,
                    SKU = 200200,
                    Name = "Hilda",
                    Price = 425,
                    RoomCollection = "Dining",
                    TypeCollection = "Dining Table",
                    Image = "https://target.scene7.com/is/image/Target/GUEST_c9fe7839-1916-435d-80db-01bdd3f2551b?wid=488&hei=488&fmt=pjpeg"
                },
                new Furniture
                {
                    ID = 6,
                    SKU = 200300,
                    Name = "Janice",
                    Price = 490,
                    RoomCollection = "Dining",
                    TypeCollection = "Dining Table",
                    Image = "https://st.hzcdn.com/simgs/cf61443f055a0cb5_4-3919/home-design.jpg"
                },
                new Furniture
                {
                    ID = 7,
                    SKU = 300100,
                    Name = "Stuart",
                    Price = 550,
                    RoomCollection = "Bedroom",
                    TypeCollection = "Dresser",
                    Image = "https://www.westelm.com/weimgs/rk/images/wcm/products/201824/0267/modern-6-drawer-dresser-o.jpg"
                },
                new Furniture
                {
                    ID = 8,
                    SKU = 300200,
                    Name = "Millie",
                    Price = 650,
                    RoomCollection = "Bedroom",
                    TypeCollection = "Dresser",
                    Image = "http://www.sleekmodernfurniture.com/Shared/Images/Product/Daniel-Dresser-Cabinet-Walnut/daniel-dresser-cabinet-walnut.jpg"
                },
                new Furniture
                {
                    ID = 9,
                    SKU = 300300,
                    Name = "Eva",
                    Price = 770,
                    RoomCollection = "Bedroom",
                    TypeCollection = "Bed",
                    Image = "https://www.westelm.com/weimgs/ab/images/wcm/products/201824/0308/modern-bed-linen-weave-c.jpg"
                },
                new Furniture
                {
                    ID = 10,
                    SKU = 300400,
                    Name = "Tillie",
                    Price = 690,
                    RoomCollection = "Bedroom",
                    TypeCollection = "Bed",
                    Image = "https://cdn.shopify.com/s/files/1/0392/0005/products/mod_bed_photo_render2_WEB.jpg?v=1518632143"
                },
                new Furniture
                {
                    ID = 11,
                    SKU = 400100,
                    Name = "Bella",
                    Price = 175,
                    RoomCollection = "Lighting",
                    TypeCollection = "Wall Sconce",
                    Image = "https://images.beautifulhalo.com/images/400x400/201710/N/vintage-bubble-wall-lamp-two-lights_1508750654872.jpg"
                },
                new Furniture
                {
                    ID = 12,
                    SKU = 400200,
                    Name = "Patricia",
                    Price = 345,
                    RoomCollection = "Lighting",
                    TypeCollection = "Ceiling Lighting",
                    Image = "https://cdn.shopify.com/s/files/1/0229/6239/products/prisma-globe-chandelier-brass-white-1_bf6a5d92-c3c5-4f28-aeb7-c4578b60a1d1_1024x1024.jpg?v=1521732321"
                },
                new Furniture
                {
                    ID = 13,
                    SKU = 400300,
                    Name = "Stanley",
                    Price = 275,
                    RoomCollection = "Lighting",
                    TypeCollection = "Ceiling Lighting",
                    Image = "https://images.lumens.com/is/image/Lumens/web_uu394080_alt02?$Lumens.com-220$staticlink$"
                },
                new Furniture
                {
                    ID = 14,
                    SKU = 500100,
                    Name = "Frida",
                    Price = 640,
                    RoomCollection = "Seasonal",
                    TypeCollection = "Patio Chair",
                    Image = "https://meisucn.com/wp-content/uploads/2018/09/modern-patio-furniture-that-brings-the-indoors-outside-related-to-modern-patio-chair-of-modern-patio-chair.jpg"
                },
                new Furniture
                {
                    ID = 15,
                    SKU = 500200,
                    Name = "Aston",
                    Price = 1290,
                    RoomCollection = "Seasonal",
                    TypeCollection = "Patio Dining Set",
                    Image = "http://crystalyou.site/wp-content/uploads/2018/03/modern-outdoor-patio-furniture-outdoor-modern-chairs-mid-century-modern-outdoor-patio-furniture-modern-outdoor-dining-chairs-modern-outdoor-patio-furniture-toronto.jpg"
                },
                new Furniture
                {
                    ID = 16,
                    SKU = 600100,
                    Name = "Ernie",
                    Price = 150,
                    RoomCollection = "Clearance",
                    TypeCollection = "Dining Table",
                    Image = "http://cdn.shopify.com/s/files/1/2024/3521/products/BK-DK-2_b15dd418-1b2d-44bb-bbdf-eacdb1a26e22_grande.jpg?v=1517918760"
                }
            );
        }
        public DbSet<Furniture> Furniture { get; set; }
        public DbSet<Basket> Basket { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}
