using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class db2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 18, 1, 26, 785, DateTimeKind.Local).AddTicks(15),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 14, 0, 36, 328, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 18, 1, 26, 772, DateTimeKind.Local).AddTicks(7345),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 14, 0, 36, 317, DateTimeKind.Local).AddTicks(1162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdd",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 18, 1, 26, 757, DateTimeKind.Local).AddTicks(9388),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 14, 0, 36, 304, DateTimeKind.Local).AddTicks(125));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 14, 0, 36, 328, DateTimeKind.Local).AddTicks(4483),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 18, 1, 26, 785, DateTimeKind.Local).AddTicks(15));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 14, 0, 36, 317, DateTimeKind.Local).AddTicks(1162),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 18, 1, 26, 772, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdd",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 14, 0, 36, 304, DateTimeKind.Local).AddTicks(125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 18, 1, 26, 757, DateTimeKind.Local).AddTicks(9388));
        }
    }
}
