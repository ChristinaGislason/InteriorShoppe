using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InteriorShoppe.Migrations
{
    public partial class getRidOfUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Basket_ApplicationUser_UserID",
                table: "Basket");

            migrationBuilder.DropForeignKey(
                name: "FK_Furniture_Basket_BasketID",
                table: "Furniture");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

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

            migrationBuilder.CreateIndex(
                name: "IX_Basket_FurnitureID",
                table: "Basket",
                column: "FurnitureID",
                unique: true);

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
                name: "FK_Basket_Furniture_FurnitureID",
                table: "Basket");

            migrationBuilder.DropIndex(
                name: "IX_Basket_FurnitureID",
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

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Furniture_BasketID",
                table: "Furniture",
                column: "BasketID");

            migrationBuilder.CreateIndex(
                name: "IX_Basket_UserID",
                table: "Basket",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Basket_ApplicationUser_UserID",
                table: "Basket",
                column: "UserID",
                principalTable: "ApplicationUser",
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
