using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class data3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Products",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 17, 16, 3, 8, 511, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Images",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 17, 16, 3, 8, 504, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdd",
                table: "Carts",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 23, 19, 40, 8, 720, DateTimeKind.Local).AddTicks(1509),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 17, 16, 3, 8, 490, DateTimeKind.Local).AddTicks(6600));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 17, 16, 3, 8, 511, DateTimeKind.Local).AddTicks(2118),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 17, 16, 3, 8, 504, DateTimeKind.Local).AddTicks(1866),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdd",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 17, 16, 3, 8, 490, DateTimeKind.Local).AddTicks(6600),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 23, 19, 40, 8, 720, DateTimeKind.Local).AddTicks(1509));
        }
    }
}
