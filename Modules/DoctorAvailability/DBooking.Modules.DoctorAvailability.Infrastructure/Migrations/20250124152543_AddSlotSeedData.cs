using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DBooking.Modules.DoctorAvailability.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSlotSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "DoctorAvailability",
                table: "Slots",
                columns: new[] { "Id", "Cost", "CreationDate", "DoctorId", "DoctorName", "IsReserved", "Time" },
                values: new object[,]
                {
                    { new Guid("0c3aa35e-4c09-41d9-a47e-d7b47fdc6587"), 150m, new DateTime(2025, 1, 24, 15, 25, 41, 386, DateTimeKind.Utc).AddTicks(577), new Guid("b08ef79d-2e87-4b7e-91c6-542d3a3b4678"), "Doctor 1", false, new DateTime(2025, 1, 26, 15, 25, 41, 386, DateTimeKind.Utc).AddTicks(578) },
                    { new Guid("753fa6b7-3846-485e-9c82-769a1bebb503"), 250m, new DateTime(2025, 1, 24, 15, 25, 41, 386, DateTimeKind.Utc).AddTicks(588), new Guid("b08ef79d-2e87-4b7e-91c6-542d3a3b4678"), "Doctor 1", false, new DateTime(2025, 1, 27, 15, 25, 41, 386, DateTimeKind.Utc).AddTicks(588) },
                    { new Guid("af4e18e3-9883-4ac5-bbfe-cefc958bf746"), 350m, new DateTime(2025, 1, 24, 15, 25, 41, 386, DateTimeKind.Utc).AddTicks(590), new Guid("b08ef79d-2e87-4b7e-91c6-542d3a3b4678"), "Doctor 1", false, new DateTime(2025, 1, 28, 15, 25, 41, 386, DateTimeKind.Utc).AddTicks(591) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "DoctorAvailability",
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("0c3aa35e-4c09-41d9-a47e-d7b47fdc6587"));

            migrationBuilder.DeleteData(
                schema: "DoctorAvailability",
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("753fa6b7-3846-485e-9c82-769a1bebb503"));

            migrationBuilder.DeleteData(
                schema: "DoctorAvailability",
                table: "Slots",
                keyColumn: "Id",
                keyValue: new Guid("af4e18e3-9883-4ac5-bbfe-cefc958bf746"));
        }
    }
}
