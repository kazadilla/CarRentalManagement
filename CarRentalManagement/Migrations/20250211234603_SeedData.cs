using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 12, 7, 46, 2, 963, DateTimeKind.Local).AddTicks(2000), new DateTime(2025, 2, 12, 7, 46, 2, 963, DateTimeKind.Local).AddTicks(2024), "Black", "System" },
                    { 2, "System", new DateTime(2025, 2, 12, 7, 46, 2, 963, DateTimeKind.Local).AddTicks(2028), new DateTime(2025, 2, 12, 7, 46, 2, 963, DateTimeKind.Local).AddTicks(2028), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 12, 7, 46, 2, 963, DateTimeKind.Local).AddTicks(2350), new DateTime(2025, 2, 12, 7, 46, 2, 963, DateTimeKind.Local).AddTicks(2351), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 2, 12, 7, 46, 2, 963, DateTimeKind.Local).AddTicks(2354), new DateTime(2025, 2, 12, 7, 46, 2, 963, DateTimeKind.Local).AddTicks(2355), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 12, 7, 46, 2, 963, DateTimeKind.Local).AddTicks(2487), new DateTime(2025, 2, 12, 7, 46, 2, 963, DateTimeKind.Local).AddTicks(2488), "i4", "System" },
                    { 2, "System", new DateTime(2025, 2, 12, 7, 46, 2, 963, DateTimeKind.Local).AddTicks(2554), new DateTime(2025, 2, 12, 7, 46, 2, 963, DateTimeKind.Local).AddTicks(2555), "x5", "System" },
                    { 3, "System", new DateTime(2025, 2, 12, 7, 46, 2, 963, DateTimeKind.Local).AddTicks(2558), new DateTime(2025, 2, 12, 7, 46, 2, 963, DateTimeKind.Local).AddTicks(2559), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 2, 12, 7, 46, 2, 963, DateTimeKind.Local).AddTicks(2562), new DateTime(2025, 2, 12, 7, 46, 2, 963, DateTimeKind.Local).AddTicks(2563), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
