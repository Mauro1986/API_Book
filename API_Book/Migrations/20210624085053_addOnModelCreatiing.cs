using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Book.Migrations
{
    public partial class addOnModelCreatiing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "DateRead", "Description", "Genre", "Rate", "Title" },
                values: new object[] { 1, new DateTime(2021, 6, 24, 10, 50, 53, 166, DateTimeKind.Local).AddTicks(7690), "Harry Potter", "Sci-Fi", 9, "Harry Potter" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "DateRead", "Description", "Genre", "Rate", "Title" },
                values: new object[] { 2, new DateTime(2021, 6, 24, 10, 50, 53, 169, DateTimeKind.Local).AddTicks(2773), "Zorro", "Adventure", 7, "Zorro" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "DateRead", "Description", "Genre", "Rate", "Title" },
                values: new object[] { 3, new DateTime(2021, 6, 24, 10, 50, 53, 169, DateTimeKind.Local).AddTicks(2802), "Tarzan", "Adventure", 6, "Tarzan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
