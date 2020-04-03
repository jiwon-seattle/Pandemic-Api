using Microsoft.EntityFrameworkCore.Migrations;

namespace Pandemic.Migrations
{
    public partial class SeedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 2,
                columns: new[] { "Lat", "Lon" },
                values: new object[] { 40, -4 });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 5,
                column: "Cases",
                value: 12);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 2,
                columns: new[] { "Lat", "Lon" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 5,
                column: "Cases",
                value: 26);
        }
    }
}
