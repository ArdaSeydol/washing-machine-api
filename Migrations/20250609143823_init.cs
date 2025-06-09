using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GroupA.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "John", "Doe", null },
                    { 2, "Arda", "Seydol", "+485172096501" }
                });

            migrationBuilder.InsertData(
                table: "Program",
                columns: new[] { "ProgramId", "DurationMinutes", "Name", "TemperatureCelsius" },
                values: new object[,]
                {
                    { 1, 69, "Quick Wash", 0 },
                    { 2, 143, "Cotton Cycle", 0 },
                    { 3, 190, "Synthetic", 0 }
                });

            migrationBuilder.InsertData(
                table: "WashingMachines",
                columns: new[] { "WashingMachineId", "MaxWeight", "SerialNumber" },
                values: new object[,]
                {
                    { 1, 32.23m, "WM2012/S431/12" },
                    { 2, 52.23m, "WM2014/S491/28" }
                });

            migrationBuilder.InsertData(
                table: "AvailablePrograms",
                columns: new[] { "AvailableProgramId", "Price", "ProgramId", "WashingMachineId" },
                values: new object[,]
                {
                    { 1, 100.00m, 1, 1 },
                    { 2, 150.00m, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "PurchaseHistory",
                columns: new[] { "AvailableProgramId", "CustomerId", "PurchaseDate", "Rating" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 2, 2, new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Program",
                keyColumn: "ProgramId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PurchaseHistory",
                keyColumns: new[] { "AvailableProgramId", "CustomerId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PurchaseHistory",
                keyColumns: new[] { "AvailableProgramId", "CustomerId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "WashingMachines",
                keyColumn: "WashingMachineId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AvailablePrograms",
                keyColumn: "AvailableProgramId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AvailablePrograms",
                keyColumn: "AvailableProgramId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Program",
                keyColumn: "ProgramId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Program",
                keyColumn: "ProgramId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WashingMachines",
                keyColumn: "WashingMachineId",
                keyValue: 1);
        }
    }
}
