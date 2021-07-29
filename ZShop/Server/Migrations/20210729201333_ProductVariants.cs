using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZShop.Server.Migrations
{
    public partial class ProductVariants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlatformProduct");

            migrationBuilder.DropColumn(
                name: "OriginalPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductVariant",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    PlatformId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariant", x => new { x.ProductId, x.PlatformId });
                    table.ForeignKey(
                        name: "FK_ProductVariant_Platforms_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariant_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductVariant",
                columns: new[] { "PlatformId", "ProductId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 4, 7, 69.99m, 59.99m },
                    { 8, 14, 58.99m, 43.99m },
                    { 5, 14, 64.99m, 63.99m },
                    { 4, 14, 64.99m, 53.99m },
                    { 1, 14, 79.99m, 59.99m },
                    { 4, 13, 55.99m, 36.99m },
                    { 4, 11, 34.99m, 23.99m },
                    { 5, 10, 64.99m, 53.99m },
                    { 4, 10, 60.99m, 54.99m },
                    { 2, 10, 54.99m, 49.99m },
                    { 1, 10, 64.99m, 59.99m },
                    { 4, 9, 49.99m, 19.99m },
                    { 8, 8, 34.99m, 31.99m },
                    { 4, 8, 34.99m, 29.99m },
                    { 8, 15, 48.99m, 33.99m },
                    { 1, 16, 49.99m, 59.99m },
                    { 3, 5, 59.99m, 44.99m },
                    { 2, 5, 67.99m, 49.99m },
                    { 1, 5, 69.99m, 59.99m },
                    { 4, 4, 36.99m, 17.99m },
                    { 3, 4, 39.99m, 14.99m },
                    { 4, 3, 29.99m, 19.99m },
                    { 5, 2, 47.99m, 59.99m },
                    { 4, 2, 79.99m, 49.99m },
                    { 1, 2, 79.99m, 69.99m },
                    { 5, 1, 68.49m, 59.99m },
                    { 4, 1, 74.99m, 69.99m },
                    { 1, 1, 89.99m, 79.99m },
                    { 4, 6, 0m, 49.99m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "Title" },
                values: new object[,]
                {
                    { 18, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Grand Theft Auto: San Andreas is a 2004 action-adventure game developed by Rockstar North and published by Rockstar Games. It is the seventh game in the Grand Theft Auto series, following Grand Theft Auto: Vice City (2002). It was released in October 2004 for PlayStation 2, and in June 2005 for Microsoft Windows and Xbox. The game is set within an open world environment that players can explore and interact with at their leisure", "https://upload.wikimedia.org/wikipedia/en/thumb/c/c4/GTASABOX.jpg/220px-GTASABOX.jpg", false, false, "GTA San Andreas" },
                    { 17, 6, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FIFA 21 is a football simulation video game published by Electronic Arts as part of the FIFA series.[1] It is the 28th installment in the FIFA series, and was released on 9 October 2020 for Microsoft Windows, Nintendo Switch, PlayStation 4 and Xbox One. Enhanced versions for the PlayStation 5 and Xbox Series X and Series S were released on 3 December 2020, in addition to a version for Stadia in March 2021.", "https://upload.wikimedia.org/wikipedia/en/thumb/b/bb/FIFA_21_Standard_Edition_Cover.jpg/220px-FIFA_21_Standard_Edition_Cover.jpg", false, false, "FIFA 21" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariant",
                columns: new[] { "PlatformId", "ProductId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, 17, 78.99m, 73.99m },
                    { 4, 17, 69.99m, 59.99m },
                    { 5, 17, 69.99m, 64.99m },
                    { 3, 18, 69.99m, 44.99m },
                    { 4, 18, 49.99m, 39.99m },
                    { 7, 18, 39.99m, 34.99m },
                    { 8, 18, 29.99m, 27.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariant_PlatformId",
                table: "ProductVariant",
                column: "PlatformId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVariant");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.AddColumn<decimal>(
                name: "OriginalPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "PlatformProduct",
                columns: table => new
                {
                    PlatformsId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlatformProduct", x => new { x.PlatformsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_PlatformProduct_Platforms_PlatformsId",
                        column: x => x.PlatformsId,
                        principalTable: "Platforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlatformProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PlatformProduct",
                columns: new[] { "PlatformsId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 4, 15 },
                    { 1, 16 },
                    { 4, 16 },
                    { 5, 16 },
                    { 2, 22 },
                    { 4, 22 },
                    { 5, 22 },
                    { 6, 22 },
                    { 3, 23 },
                    { 3, 15 },
                    { 4, 23 },
                    { 8, 23 },
                    { 1, 24 },
                    { 2, 24 },
                    { 3, 24 },
                    { 4, 24 },
                    { 5, 24 },
                    { 6, 24 },
                    { 7, 24 },
                    { 8, 24 },
                    { 7, 23 },
                    { 8, 15 },
                    { 1, 22 },
                    { 5, 14 },
                    { 4, 1 },
                    { 5, 1 },
                    { 4, 3 },
                    { 3, 4 },
                    { 6, 14 },
                    { 1, 5 },
                    { 4, 5 },
                    { 5, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 5, 8 },
                    { 4, 4 },
                    { 4, 9 },
                    { 5, 10 },
                    { 4, 10 },
                    { 8, 11 },
                    { 4, 11 }
                });

            migrationBuilder.InsertData(
                table: "PlatformProduct",
                columns: new[] { "PlatformsId", "ProductsId" },
                values: new object[,]
                {
                    { 4, 13 },
                    { 1, 14 },
                    { 2, 14 },
                    { 4, 14 },
                    { 4, 8 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 79.99m, 69.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 64.99m, 49.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 16.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 25.00m, 12.50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 49.99m, 39.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 89.99m, 69.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 29.99m, 8.19m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 24.99m, 9.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 30.00m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: 44.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 32.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Price",
                value: 27.49m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Price",
                value: 39.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Price",
                value: 19.49m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: 27.49m);

            migrationBuilder.CreateIndex(
                name: "IX_PlatformProduct_ProductsId",
                table: "PlatformProduct",
                column: "ProductsId");
        }
    }
}
