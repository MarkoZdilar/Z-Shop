using Microsoft.EntityFrameworkCore.Migrations;

namespace ZShop.Server.Migrations
{
    public partial class PlatformSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Play Station 5" },
                    { 2, "Play Station 4" },
                    { 3, "Play Station 3" },
                    { 4, "PC" },
                    { 5, "Xbox Series X" },
                    { 6, "Xbox One" },
                    { 7, "Xbox 360" },
                    { 8, "Nintendo Wii" }
                });

            migrationBuilder.InsertData(
                table: "PlatformProduct",
                columns: new[] { "PlatformsId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 4, 15 },
                    { 4, 16 },
                    { 4, 22 },
                    { 4, 23 },
                    { 4, 24 },
                    { 5, 1 },
                    { 5, 5 },
                    { 5, 8 },
                    { 5, 10 },
                    { 4, 14 },
                    { 5, 14 },
                    { 5, 22 },
                    { 5, 24 },
                    { 6, 14 },
                    { 6, 22 },
                    { 6, 24 },
                    { 7, 23 },
                    { 7, 24 },
                    { 8, 11 },
                    { 8, 15 },
                    { 5, 16 },
                    { 8, 23 },
                    { 4, 13 },
                    { 4, 10 },
                    { 1, 5 },
                    { 1, 14 },
                    { 1, 16 },
                    { 1, 22 },
                    { 1, 24 },
                    { 2, 14 },
                    { 2, 22 },
                    { 2, 24 },
                    { 3, 4 },
                    { 4, 11 },
                    { 3, 15 },
                    { 3, 24 },
                    { 4, 1 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 }
                });

            migrationBuilder.InsertData(
                table: "PlatformProduct",
                columns: new[] { "PlatformsId", "ProductsId" },
                values: new object[,]
                {
                    { 4, 7 },
                    { 4, 8 },
                    { 4, 9 },
                    { 3, 23 },
                    { 8, 24 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 1, 24 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 2, 22 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 2, 24 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 3, 23 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 3, 24 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 4, 15 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 4, 22 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 4, 23 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 4, 24 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 5, 22 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 5, 24 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 6, 14 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 6, 22 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 6, 24 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 7, 23 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 7, 24 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 8, 11 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 8, 15 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 8, 23 });

            migrationBuilder.DeleteData(
                table: "PlatformProduct",
                keyColumns: new[] { "PlatformsId", "ProductsId" },
                keyValues: new object[] { 8, 24 });

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
