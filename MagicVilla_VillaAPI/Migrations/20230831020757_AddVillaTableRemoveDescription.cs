using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    public partial class AddVillaTableRemoveDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Villas");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "Name", "Occupancy", "UpdatedDate", "rate", "sqft" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 8, 30, 21, 7, 56, 876, DateTimeKind.Local).AddTicks(613), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Royal Villa", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200, 550 },
                    { 2, "", new DateTime(2023, 8, 30, 21, 7, 56, 876, DateTimeKind.Local).AddTicks(644), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Premium Pool Villa", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 300, 550 },
                    { 3, "", new DateTime(2023, 8, 30, 21, 7, 56, 876, DateTimeKind.Local).AddTicks(646), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Luxury Pool Villa", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 400, 750 },
                    { 4, "", new DateTime(2023, 8, 30, 21, 7, 56, 876, DateTimeKind.Local).AddTicks(649), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Diamond Villa", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 550, 900 },
                    { 5, "", new DateTime(2023, 8, 30, 21, 7, 56, 876, DateTimeKind.Local).AddTicks(651), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Diamond Pool Villa", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 600, 1100 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<double>(
                name: "Details",
                table: "Villas",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
