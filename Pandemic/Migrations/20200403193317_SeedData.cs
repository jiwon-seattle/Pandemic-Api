using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pandemic.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Statuses_Countries_countryId",
                table: "Statuses");

            migrationBuilder.RenameColumn(
                name: "countryId",
                table: "Statuses",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Statuses_countryId",
                table: "Statuses",
                newName: "IX_Statuses_CountryId");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryName", "Lat", "Lon" },
                values: new object[,]
                {
                    { 1, "Korea", 0, 0 },
                    { 2, "Spain", 0, 0 },
                    { 3, "USA", 0, 0 },
                    { 4, "Mexico", 0, 0 },
                    { 5, "Japan", 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusId", "Cases", "Confirmed", "CountryId", "Date" },
                values: new object[,]
                {
                    { 1, 10, true, 1, new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 30, true, 2, new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 50, true, 3, new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 26, true, 4, new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 26, true, 5, new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Statuses_Countries_CountryId",
                table: "Statuses",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Statuses_Countries_CountryId",
                table: "Statuses");

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 5);

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Statuses",
                newName: "countryId");

            migrationBuilder.RenameIndex(
                name: "IX_Statuses_CountryId",
                table: "Statuses",
                newName: "IX_Statuses_countryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Statuses_Countries_countryId",
                table: "Statuses",
                column: "countryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
