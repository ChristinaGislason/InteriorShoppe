using Microsoft.EntityFrameworkCore.Migrations;

namespace InteriorShoppe.Migrations
{
    public partial class updatebasket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Furniture_Basket_basketID",
                table: "Furniture");

            migrationBuilder.RenameColumn(
                name: "basketID",
                table: "Furniture",
                newName: "BasketID");

            migrationBuilder.RenameIndex(
                name: "IX_Furniture_basketID",
                table: "Furniture",
                newName: "IX_Furniture_BasketID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Basket",
                newName: "BasketID");

            migrationBuilder.AddForeignKey(
                name: "FK_Furniture_Basket_BasketID",
                table: "Furniture",
                column: "BasketID",
                principalTable: "Basket",
                principalColumn: "BasketID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Furniture_Basket_BasketID",
                table: "Furniture");

            migrationBuilder.RenameColumn(
                name: "BasketID",
                table: "Furniture",
                newName: "basketID");

            migrationBuilder.RenameIndex(
                name: "IX_Furniture_BasketID",
                table: "Furniture",
                newName: "IX_Furniture_basketID");

            migrationBuilder.RenameColumn(
                name: "BasketID",
                table: "Basket",
                newName: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Furniture_Basket_basketID",
                table: "Furniture",
                column: "basketID",
                principalTable: "Basket",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
