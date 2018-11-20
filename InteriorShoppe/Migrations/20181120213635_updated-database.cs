using Microsoft.EntityFrameworkCore.Migrations;

namespace InteriorShoppe.Migrations
{
    public partial class updateddatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 1,
                column: "TypeCollection",
                value: "Couch");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 2,
                column: "TypeCollection",
                value: "Couch");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 3,
                column: "TypeCollection",
                value: "Couch Set");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 4,
                column: "TypeCollection",
                value: "Dining Chair");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 5,
                column: "TypeCollection",
                value: "Dining Table");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 6,
                column: "TypeCollection",
                value: "Dining Table");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 7,
                column: "TypeCollection",
                value: "Dresser");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 8,
                column: "TypeCollection",
                value: "Dresser");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 9,
                column: "TypeCollection",
                value: "Bed");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 10,
                column: "TypeCollection",
                value: "Bed");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 11,
                column: "TypeCollection",
                value: "Wall Sconce");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 12,
                column: "TypeCollection",
                value: "Ceiling Lighting");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 13,
                column: "TypeCollection",
                value: "Ceiling Lighting");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 14,
                column: "TypeCollection",
                value: "Patio Chair");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 15,
                column: "TypeCollection",
                value: "Patio Dining Set");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 16,
                column: "TypeCollection",
                value: "Dining Table");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 1,
                column: "TypeCollection",
                value: "In Stock");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 2,
                column: "TypeCollection",
                value: "Sold Out");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 3,
                column: "TypeCollection",
                value: "In Stock");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 4,
                column: "TypeCollection",
                value: "In Stock");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 5,
                column: "TypeCollection",
                value: "In Stock");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 6,
                column: "TypeCollection",
                value: "In Stock");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 7,
                column: "TypeCollection",
                value: "In Stock");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 8,
                column: "TypeCollection",
                value: "In Stock");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 9,
                column: "TypeCollection",
                value: "Sold Out");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 10,
                column: "TypeCollection",
                value: "In Stock");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 11,
                column: "TypeCollection",
                value: "In Stock");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 12,
                column: "TypeCollection",
                value: "In Stock");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 13,
                column: "TypeCollection",
                value: "Sold Out");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 14,
                column: "TypeCollection",
                value: "In Stock");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 15,
                column: "TypeCollection",
                value: "In Stock");

            migrationBuilder.UpdateData(
                table: "Furniture",
                keyColumn: "ID",
                keyValue: 16,
                column: "TypeCollection",
                value: "In Stock");
        }
    }
}
