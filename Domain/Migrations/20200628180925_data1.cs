using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class data1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductImage",
                table: "Products",
                maxLength: 50,
                nullable: false,
                defaultValue: "default.jpg");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdd",
                table: "Carts",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 29, 1, 9, 24, 795, DateTimeKind.Local).AddTicks(7691),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 27, 10, 58, 57, 342, DateTimeKind.Local).AddTicks(867));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductImage",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdd",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 27, 10, 58, 57, 342, DateTimeKind.Local).AddTicks(867),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 29, 1, 9, 24, 795, DateTimeKind.Local).AddTicks(7691));
        }
    }
}
