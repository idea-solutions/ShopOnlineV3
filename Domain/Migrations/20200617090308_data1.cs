using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class data1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 17, 16, 3, 8, 511, DateTimeKind.Local).AddTicks(2118),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 17, 14, 36, 30, 641, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 17, 16, 3, 8, 504, DateTimeKind.Local).AddTicks(1866),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 17, 14, 36, 30, 635, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.AlterColumn<Guid>(
                name: "SubCategoryId",
                table: "Categories",
                nullable: false,
                defaultValue: new Guid("e2d07078-84d1-4875-9da7-4aeed81225d3"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdd",
                table: "Carts",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 17, 16, 3, 8, 490, DateTimeKind.Local).AddTicks(6600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 6, 17, 14, 36, 30, 622, DateTimeKind.Local).AddTicks(9499));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 17, 14, 36, 30, 641, DateTimeKind.Local).AddTicks(7880),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 17, 16, 3, 8, 511, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreate",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 17, 14, 36, 30, 635, DateTimeKind.Local).AddTicks(8109),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 17, 16, 3, 8, 504, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.AlterColumn<Guid>(
                name: "SubCategoryId",
                table: "Categories",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldDefaultValue: new Guid("e2d07078-84d1-4875-9da7-4aeed81225d3"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdd",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 6, 17, 14, 36, 30, 622, DateTimeKind.Local).AddTicks(9499),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 6, 17, 16, 3, 8, 490, DateTimeKind.Local).AddTicks(6600));
        }
    }
}
