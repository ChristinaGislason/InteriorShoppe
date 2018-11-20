﻿// <auto-generated />
using InteriorShoppe.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InteriorShoppe.Migrations
{
    [DbContext(typeof(InteriorShoppeDbContext))]
    partial class InteriorShoppeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InteriorShoppe.Models.Furniture", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("Price");

                    b.Property<string>("RoomCollection");

                    b.Property<int>("SKU");

                    b.Property<string>("TypeCollection");

                    b.HasKey("ID");

                    b.ToTable("Furniture");

                    b.HasData(
                        new { ID = 1, Image = "https://joybird2.imgix.net/image_1054_109.jpg?", Name = "Heather", Price = 2550m, RoomCollection = "Living", SKU = 100100, TypeCollection = "In Stock" },
                        new { ID = 2, Image = "https://images-na.ssl-images-amazon.com/images/I/816d2dCTdQL._SX425_.jpg", Name = "Elliot", Price = 1850m, RoomCollection = "Living", SKU = 100200, TypeCollection = "Sold Out" },
                        new { ID = 3, Image = "https://cdn.shopify.com/s/files/1/1811/5643/products/BBT8013-Black_203pc_20Set-1_8b7e879b-43cb-48e6-9e98-321c13411265_1400x.jpg?v=1507179360", Name = "Henry", Price = 1690m, RoomCollection = "Living", SKU = 100300, TypeCollection = "In Stock" },
                        new { ID = 4, Image = "https://cdn.shopify.com/s/files/1/0819/6713/products/4747mid-century-modern-dining-chairs-aqua_5319e712-12fa-4d84-b404-8fb0ccbdfb29_large.jpg?v=1472838603", Name = "Preston", Price = 220m, RoomCollection = "Dining", SKU = 200100, TypeCollection = "In Stock" },
                        new { ID = 5, Image = "https://target.scene7.com/is/image/Target/GUEST_c9fe7839-1916-435d-80db-01bdd3f2551b?wid=488&hei=488&fmt=pjpeg", Name = "Hilda", Price = 425m, RoomCollection = "Dining", SKU = 200200, TypeCollection = "In Stock" },
                        new { ID = 6, Image = "https://st.hzcdn.com/simgs/cf61443f055a0cb5_4-3919/home-design.jpg", Name = "Janice", Price = 490m, RoomCollection = "Dining", SKU = 200300, TypeCollection = "In Stock" },
                        new { ID = 7, Image = "https://www.westelm.com/weimgs/rk/images/wcm/products/201824/0267/modern-6-drawer-dresser-o.jpg", Name = "Stuart", Price = 550m, RoomCollection = "Bedroom", SKU = 300100, TypeCollection = "In Stock" },
                        new { ID = 8, Image = "http://www.sleekmodernfurniture.com/Shared/Images/Product/Daniel-Dresser-Cabinet-Walnut/daniel-dresser-cabinet-walnut.jpg", Name = "Millie", Price = 650m, RoomCollection = "Bedroom", SKU = 300200, TypeCollection = "In Stock" },
                        new { ID = 9, Image = "https://www.westelm.com/weimgs/ab/images/wcm/products/201824/0308/modern-bed-linen-weave-c.jpg", Name = "Eva", Price = 770m, RoomCollection = "Bedroom", SKU = 300300, TypeCollection = "Sold Out" },
                        new { ID = 10, Image = "https://cdn.shopify.com/s/files/1/0392/0005/products/mod_bed_photo_render2_WEB.jpg?v=1518632143", Name = "Tillie", Price = 690m, RoomCollection = "Bedroom", SKU = 300400, TypeCollection = "In Stock" },
                        new { ID = 11, Image = "https://images.beautifulhalo.com/images/400x400/201710/N/vintage-bubble-wall-lamp-two-lights_1508750654872.jpg", Name = "Bella", Price = 175m, RoomCollection = "Lighting", SKU = 400100, TypeCollection = "In Stock" },
                        new { ID = 12, Image = "https://cdn.shopify.com/s/files/1/0229/6239/products/prisma-globe-chandelier-brass-white-1_bf6a5d92-c3c5-4f28-aeb7-c4578b60a1d1_1024x1024.jpg?v=1521732321", Name = "Patricia", Price = 345m, RoomCollection = "Lighting", SKU = 400200, TypeCollection = "In Stock" },
                        new { ID = 13, Image = "https://images.lumens.com/is/image/Lumens/web_uu394080_alt02?$Lumens.com-220$staticlink$", Name = "Stanley", Price = 275m, RoomCollection = "Lighting", SKU = 400300, TypeCollection = "Sold Out" },
                        new { ID = 14, Image = "https://meisucn.com/wp-content/uploads/2018/09/modern-patio-furniture-that-brings-the-indoors-outside-related-to-modern-patio-chair-of-modern-patio-chair.jpg", Name = "Frida", Price = 640m, RoomCollection = "Seasonal", SKU = 500100, TypeCollection = "In Stock" },
                        new { ID = 15, Image = "http://crystalyou.site/wp-content/uploads/2018/03/modern-outdoor-patio-furniture-outdoor-modern-chairs-mid-century-modern-outdoor-patio-furniture-modern-outdoor-dining-chairs-modern-outdoor-patio-furniture-toronto.jpg", Name = "Aston", Price = 1290m, RoomCollection = "Seasonal", SKU = 500200, TypeCollection = "In Stock" },
                        new { ID = 16, Image = "http://cdn.shopify.com/s/files/1/2024/3521/products/BK-DK-2_b15dd418-1b2d-44bb-bbdf-eacdb1a26e22_grande.jpg?v=1517918760", Name = "Ernie", Price = 150m, RoomCollection = "Clearance", SKU = 600100, TypeCollection = "In Stock" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
