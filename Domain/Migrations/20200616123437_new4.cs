using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class new4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 19, 34, 37, 323, DateTimeKind.Local).AddTicks(7528),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 18, 1, 26, 785, DateTimeKind.Local).AddTicks(15));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 19, 34, 37, 317, DateTimeKind.Local).AddTicks(6557),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 18, 1, 26, 772, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdd",
                table: "Carts",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 19, 34, 37, 303, DateTimeKind.Local).AddTicks(6762),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 16, 18, 1, 26, 757, DateTimeKind.Local).AddTicks(9388));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 18, 1, 26, 785, DateTimeKind.Local).AddTicks(15),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 16, 19, 34, 37, 323, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 18, 1, 26, 772, DateTimeKind.Local).AddTicks(7345),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 16, 19, 34, 37, 317, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdd",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 16, 18, 1, 26, 757, DateTimeKind.Local).AddTicks(9388),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 16, 19, 34, 37, 303, DateTimeKind.Local).AddTicks(6762));
        }
    }
}
