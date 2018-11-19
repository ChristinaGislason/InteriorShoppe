using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InteriorShoppe.Migrations
{
    public partial class AddImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Furniture",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SKU = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    RoomCollection = table.Column<string>(nullable: true),
                    TypeCollection = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Furniture", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Furniture",
                columns: new[] { "ID", "Image", "Name", "Price", "RoomCollection", "SKU", "TypeCollection" },
                values: new object[,]
                {
                    { 1, "https://joybird2.imgix.net/image_1054_109.jpg?", "Heather", 2550m, "Living", 100100, "In Stock" },
                    { 2, "https://images-na.ssl-images-amazon.com/images/I/816d2dCTdQL._SX425_.jpg", "Elliot", 1850m, "Living", 100200, "Sold Out" },
                    { 3, "https://cdn.shopify.com/s/files/1/1811/5643/products/BBT8013-Black_203pc_20Set-1_8b7e879b-43cb-48e6-9e98-321c13411265_1400x.jpg?v=1507179360", "Henry", 1690m, "Living", 100300, "In Stock" },
                    { 4, "https://cdn.shopify.com/s/files/1/0819/6713/products/4747mid-century-modern-dining-chairs-aqua_5319e712-12fa-4d84-b404-8fb0ccbdfb29_large.jpg?v=1472838603", "Preston", 220m, "Dining", 200100, "In Stock" },
                    { 5, "https://target.scene7.com/is/image/Target/GUEST_c9fe7839-1916-435d-80db-01bdd3f2551b?wid=488&hei=488&fmt=pjpeg", "Hilda", 425m, "Dining", 200200, "In Stock" },
                    { 6, "https://st.hzcdn.com/simgs/cf61443f055a0cb5_4-3919/home-design.jpg", "Janice", 490m, "Dining", 200300, "In Stock" },
                    { 7, "https://www.westelm.com/weimgs/rk/images/wcm/products/201824/0267/modern-6-drawer-dresser-o.jpg", "Stuart", 550m, "Bedroom", 300100, "In Stock" },
                    { 8, "http://www.sleekmodernfurniture.com/Shared/Images/Product/Daniel-Dresser-Cabinet-Walnut/daniel-dresser-cabinet-walnut.jpg", "Millie", 650m, "Bedroom", 300200, "In Stock" },
                    { 9, "https://www.westelm.com/weimgs/ab/images/wcm/products/201824/0308/modern-bed-linen-weave-c.jpg", "Eva", 770m, "Bedroom", 300300, "Sold Out" },
                    { 10, "https://cdn.shopify.com/s/files/1/0392/0005/products/mod_bed_photo_render2_WEB.jpg?v=1518632143", "Tillie", 690m, "Bedroom", 300400, "In Stock" },
                    { 11, "https://images.beautifulhalo.com/images/400x400/201710/N/vintage-bubble-wall-lamp-two-lights_1508750654872.jpg", "Bella", 175m, "Lighting", 400100, "In Stock" },
                    { 12, "https://cdn.shopify.com/s/files/1/0229/6239/products/prisma-globe-chandelier-brass-white-1_bf6a5d92-c3c5-4f28-aeb7-c4578b60a1d1_1024x1024.jpg?v=1521732321", "Patricia", 345m, "Lighting", 400200, "In Stock" },
                    { 13, "https://images.lumens.com/is/image/Lumens/web_uu394080_alt02?$Lumens.com-220$staticlink$", "Stanley", 275m, "Lighting", 400300, "Sold Out" },
                    { 14, "https://meisucn.com/wp-content/uploads/2018/09/modern-patio-furniture-that-brings-the-indoors-outside-related-to-modern-patio-chair-of-modern-patio-chair.jpg", "Frida", 640m, "Seasonal", 500100, "In Stock" },
                    { 15, "http://crystalyou.site/wp-content/uploads/2018/03/modern-outdoor-patio-furniture-outdoor-modern-chairs-mid-century-modern-outdoor-patio-furniture-modern-outdoor-dining-chairs-modern-outdoor-patio-furniture-toronto.jpg", "Aston", 1290m, "Seasonal", 500200, "In Stock" },
                    { 16, "http://cdn.shopify.com/s/files/1/2024/3521/products/BK-DK-2_b15dd418-1b2d-44bb-bbdf-eacdb1a26e22_grande.jpg?v=1517918760", "Ernie", 150m, "Clearance", 600100, "In Stock" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Furniture");
        }
    }
}
