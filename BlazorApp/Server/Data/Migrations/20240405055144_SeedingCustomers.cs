using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp.Server.Data.Migrations
{
    public partial class SeedingCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "CompanyName", "ContactName", "Country", "Phone", "PostalCode", "Region" },
                values: new object[] { new Guid("4832b897-b0d4-48ad-83cd-791fccfd6110"), "Random st 123", "Volos", "Hp", "Fotis", "Greece", "695 123 1234", "12345", "Magn" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "CompanyName", "ContactName", "Country", "Phone", "PostalCode", "Region" },
                values: new object[] { new Guid("4832b897-b0d4-48ad-83cd-791fccfd6112"), "Random st 13", "Volos", "Asus", "Giannis", "Greece", "695 123 1235", "12345", "Magn" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "CompanyName", "ContactName", "Country", "Phone", "PostalCode", "Region" },
                values: new object[] { new Guid("4832b897-b0d4-48ad-83cd-791fccfd6410"), "Random st 124", "Volos", "NoCompny", "tasos", "Greece", "695 123 1224", "12345", "Magn" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("4832b897-b0d4-48ad-83cd-791fccfd6110"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("4832b897-b0d4-48ad-83cd-791fccfd6112"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("4832b897-b0d4-48ad-83cd-791fccfd6410"));
        }
    }
}
