using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Several hundred years ago, humans were almost exterminated by giants. A small percentage of humanity survived by barricading themselves in a city protected by walls even taller than the tallest giants. Now the city has not seen a giant for over 100 years, before Elen and Mikasa witness the walls destruction by a super-giant.", "https://images-na.ssl-images-amazon.com/images/I/91M9VaZWxOL.jpg", 9.99m, "Attack on Titan, Vol. 1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Learning to destroy demons won’t be easy, and Tanjiro barely knows where to start. The surprise appearance of another boy named Giyu, who seems to know what’s going on, might provide some answers—but only if Tanjiro can stop Giyu from killing his sister first!", "https://images-na.ssl-images-amazon.com/images/I/81ZNkhqRvVL.jpg", 9.99m, "Kimetsu no Yaiba, Vol. 1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "To gain the power he needs to save his friend from a cursed spirit, Yuji Itadori swallows a piece of a demon, only to find himself caught in the midst of a horrific war of the supernatural!", "https://images-na.ssl-images-amazon.com/images/I/51zXJBloNpL._SX331_BO1,204,203,200_.jpg", 9.99m, "Jujutsu Kaisen, Vol. 1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
