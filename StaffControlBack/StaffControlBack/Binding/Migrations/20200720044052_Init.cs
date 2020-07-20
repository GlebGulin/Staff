using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Binding.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "positions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    PositionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Salary = table.Column<decimal>(nullable: false),
                    Hired = table.Column<DateTime>(nullable: false),
                    Fired = table.Column<DateTime>(nullable: false),
                    PositionId = table.Column<int>(nullable: false),
                    PositionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_employees_positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "positions",
                columns: new[] { "Id", "PositionName" },
                values: new object[] { 1, "Developer" });

            migrationBuilder.InsertData(
                table: "positions",
                columns: new[] { "Id", "PositionName" },
                values: new object[] { 2, "DevOps" });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "Id", "Fired", "Hired", "Name", "PositionId", "PositionName", "Salary", "Surname" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Holger", 1, "Developer", 1500m, "Göpfert" });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "Id", "Fired", "Hired", "Name", "PositionId", "PositionName", "Salary", "Surname" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steffen", 2, "DevOps", 1500m, "Frommberger" });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "Id", "Fired", "Hired", "Name", "PositionId", "PositionName", "Salary", "Surname" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Иван", 2, "DevOps", 2500m, "Петров" });

            migrationBuilder.CreateIndex(
                name: "IX_employees_PositionId",
                table: "employees",
                column: "PositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "positions");
        }
    }
}
