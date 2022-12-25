using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecomm.Server.Migrations
{
    /// <inheritdoc />
    public partial class DbSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductsC",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "70% wool / 30% polyester. The Pork Pie from Stetson deliberately dispenses with elaborate details.", "https://hatroom.pl/images/zoom/802970.jpg", 99.99m, "Uni Pork Pie Wool Hat" },
                    { 2, "50% wool / 50% polyester. Fully lined. Unisex model.", "https://www.crafters.fr/images/stories/virtuemart/tt2016/PS_B635_GREY.jpg", 75.5m, "Chapeau Urban Trilby Grey" },
                    { 3, "89% paper fiber / 11% polyester - 6cm brim - Supplied with removable black fabric strip.", "https://images.crafters.fr/bo/16951_60b0a8a70fd08_PS_KP068_NATURAL.png", 59.99m, "Chapeau Panama Natural" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductsC",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductsC",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductsC",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
