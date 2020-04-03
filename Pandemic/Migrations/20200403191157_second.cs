using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pandemic.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Statuses",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "countryId",
                table: "Statuses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Statuses_countryId",
                table: "Statuses",
                column: "countryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Statuses_Countries_countryId",
                table: "Statuses",
                column: "countryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Statuses_Countries_countryId",
                table: "Statuses");

            migrationBuilder.DropIndex(
                name: "IX_Statuses_countryId",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "countryId",
                table: "Statuses");
        }
    }
}
