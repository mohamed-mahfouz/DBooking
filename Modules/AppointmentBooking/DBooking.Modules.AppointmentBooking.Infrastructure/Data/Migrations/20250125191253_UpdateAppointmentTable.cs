using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBooking.Modules.AppointmentBooking.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAppointmentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "PatientName",
                schema: "AppointmentBooking",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                schema: "AppointmentBooking",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PatientName",
                schema: "AppointmentBooking",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Status",
                schema: "AppointmentBooking",
                table: "Appointments");
        }
    }
}
