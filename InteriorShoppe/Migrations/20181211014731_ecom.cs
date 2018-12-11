using Microsoft.EntityFrameworkCore.Migrations;

namespace InteriorShoppe.Migrations
{
    public partial class ecom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Basket_FurnitureID",
                table: "Basket");

            migrationBuilder.CreateIndex(
                name: "IX_Basket_FurnitureID",
                table: "Basket",
                column: "FurnitureID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Basket_FurnitureID",
                table: "Basket");

            migrationBuilder.CreateIndex(
                name: "IX_Basket_FurnitureID",
                table: "Basket",
                column: "FurnitureID",
                unique: true);
        }
    }
}
