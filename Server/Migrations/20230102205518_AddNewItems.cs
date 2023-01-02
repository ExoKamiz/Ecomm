using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecomm.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddNewItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductsC",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 2, "Warm evenings, ice cream and a baseball cap. And there goes summer! Go for a workout in the sunshine while wearing your adidas cap. AEROREADY wicks away sweat, keeping you feeling fresh on the pitch. The curved visor protects your eyes and the 3 stripes emphasise the sporty character. This product is made from Primegreen, a line of high-quality recycled materials.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQE2qQNtsSrONpGXAw7D5I_1zT7Tflso4MGVhTYzgAM4bvMD56OC1i4rCktunQC2wmo9-Q&usqp=CAU", 112.99m, "Baseline Hemp" },
                    { 5, 2, "Lower your head and keep pedaling through chilly weather. The Thermal Cycling Cap is an essential piece of cold weather cycling gear. Packed with the versatility of a visor and ear flaps, this cap features thermal fabric to keep you riding in the great outdoors all year long.", "https://trek.scene7.com/is/image/TrekBicycleProducts/ThermalCyclingCap_25037_A_Primary?$responsive-pjpg$&cache=on,on&wid=1920&hei=1440", 39.99m, "Bontrager Thermal" },
                    { 6, 2, "Cap is made from 100% cotton with a contemporary style and includes a Rip-strap size adjuster. A comfortable and stylish cap that is available in various colours.", "https://futbokraina.com.ua/image/cache/new/catalog/GS/kepki/black-63745.webp", 200m, "Polo Ralph Lauren" },
                    { 7, 3, "A unique balaclava specially designed for winter sports. Made with flat seam technology, it will ensure comfort even during long hours of use. The ergonomic cut created separately for men and women ensures a better fit of the balaclava to the face. ", "https://img.ltwebstatic.com/images3_pi/2022/09/09/1662702772ca0fdc2c0a9f9aefc547f60ea2c8582c_thumbnail_600x.webp", 99.99m, "Horn Decor" },
                    { 8, 3, "Provide a great protection for your face,ear and neck in the bad weather. Good for bicycle riding,skiing, or other outdoor sports. Soft and comfortable. Breathable material allows easy breath but ultra protection ldeal for the use when riding,skiing, and other outdoor sports.", "https://cdn.shopify.com/s/files/1/0634/1335/4713/products/Funny-Knitted-Face-Mask_1_900x.jpg?v=1666779905", 70m, "Gang Bang Balaclava" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductsC",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductsC",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductsC",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductsC",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductsC",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
