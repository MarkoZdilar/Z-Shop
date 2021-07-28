using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZShop.Server.Migrations
{
    public partial class ProductsRemoveFromCategoryModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 43, 17, 809, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 43, 17, 820, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 43, 17, 820, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 43, 17, 820, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 43, 17, 820, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 43, 17, 820, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 43, 17, 820, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 43, 17, 820, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 43, 17, 820, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 43, 17, 820, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 43, 17, 820, DateTimeKind.Local).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 43, 17, 820, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 43, 17, 820, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 43, 17, 820, DateTimeKind.Local).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 43, 17, 820, DateTimeKind.Local).AddTicks(5377));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 25, 37, 827, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 25, 37, 835, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 25, 37, 835, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 25, 37, 835, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 25, 37, 835, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 25, 37, 835, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 25, 37, 835, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 25, 37, 835, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 25, 37, 835, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 25, 37, 835, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 25, 37, 835, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 25, 37, 835, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 25, 37, 835, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 25, 37, 835, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 25, 37, 835, DateTimeKind.Local).AddTicks(505));
        }
    }
}
