using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecomm.Server.Migrations
{
    /// <inheritdoc />
    public partial class Categories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "ProductsC",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CategorysC",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorysC", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CategorysC",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Hat", "hat" },
                    { 2, "Cap", "cap" },
                    { 3, "Balaclava", "balaclava" }
                });

            migrationBuilder.UpdateData(
                table: "ProductsC",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductsC",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "ProductsC",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_ProductsC_CategoryId",
                table: "ProductsC",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsC_CategorysC_CategoryId",
                table: "ProductsC",
                column: "CategoryId",
                principalTable: "CategorysC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsC_CategorysC_CategoryId",
                table: "ProductsC");

            migrationBuilder.DropTable(
                name: "CategorysC");

            migrationBuilder.DropIndex(
                name: "IX_ProductsC_CategoryId",
                table: "ProductsC");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "ProductsC");
        }
    }
}
