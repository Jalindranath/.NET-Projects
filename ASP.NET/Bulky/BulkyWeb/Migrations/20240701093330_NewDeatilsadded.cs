using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BulkyWeb.Migrations
{
    /// <inheritdoc />
    public partial class NewDeatilsadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "Id", "City", "Name" },
                values: new object[,]
                {
                    { 2, 2, "Akash" },
                    { 3, 3, "Rohit" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
