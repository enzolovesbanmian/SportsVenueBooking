using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsVenueBooking.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 32, 10, 552, DateTimeKind.Local).AddTicks(2627), new DateTime(2024, 12, 8, 21, 32, 10, 552, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 32, 10, 552, DateTimeKind.Local).AddTicks(2643), new DateTime(2024, 12, 8, 21, 32, 10, 552, DateTimeKind.Local).AddTicks(2643) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 27, 14, 357, DateTimeKind.Local).AddTicks(5795), new DateTime(2024, 12, 8, 21, 27, 14, 357, DateTimeKind.Local).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 21, 27, 14, 357, DateTimeKind.Local).AddTicks(5816), new DateTime(2024, 12, 8, 21, 27, 14, 357, DateTimeKind.Local).AddTicks(5816) });
        }
    }
}
