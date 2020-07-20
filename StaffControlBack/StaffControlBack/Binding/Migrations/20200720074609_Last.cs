using Microsoft.EntityFrameworkCore.Migrations;

namespace Binding.Migrations
{
    public partial class Last : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PositionName",
                table: "employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PositionName",
                table: "employees",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "PositionName",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "PositionName",
                value: "DevOps");

            migrationBuilder.UpdateData(
                table: "employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "PositionName",
                value: "DevOps");
        }
    }
}
