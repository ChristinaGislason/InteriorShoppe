using Microsoft.EntityFrameworkCore.Migrations;

namespace InteriorShoppe.Migrations.ApplicationDb
{
    public partial class updateuserdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Basket_AspNetUsers_UserID",
                table: "Basket");

            migrationBuilder.DropForeignKey(
                name: "FK_Furniture_Basket_BasketID",
                table: "Furniture");

            migrationBuilder.DropIndex(
                name: "IX_Furniture_BasketID",
                table: "Furniture");

            migrationBuilder.DropIndex(
                name: "IX_Basket_UserID",
                table: "Basket");

            migrationBuilder.DropColumn(
                name: "BasketID",
                table: "Furniture");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Basket",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Basket",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Basket_ApplicationUserId",
                table: "Basket",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Basket_FurnitureID",
                table: "Basket",
                column: "FurnitureID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Basket_AspNetUsers_ApplicationUserId",
                table: "Basket",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Basket_Furniture_FurnitureID",
                table: "Basket",
                column: "FurnitureID",
                principalTable: "Furniture",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Basket_AspNetUsers_ApplicationUserId",
                table: "Basket");

            migrationBuilder.DropForeignKey(
                name: "FK_Basket_Furniture_FurnitureID",
                table: "Basket");

            migrationBuilder.DropIndex(
                name: "IX_Basket_ApplicationUserId",
                table: "Basket");

            migrationBuilder.DropIndex(
                name: "IX_Basket_FurnitureID",
                table: "Basket");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Basket");

            migrationBuilder.AddColumn<int>(
                name: "BasketID",
                table: "Furniture",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Basket",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Furniture_BasketID",
                table: "Furniture",
                column: "BasketID");

            migrationBuilder.CreateIndex(
                name: "IX_Basket_UserID",
                table: "Basket",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Basket_AspNetUsers_UserID",
                table: "Basket",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Furniture_Basket_BasketID",
                table: "Furniture",
                column: "BasketID",
                principalTable: "Basket",
                principalColumn: "BasketID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
