using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBooking.Modules.AppointmentBooking.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AppointmentBookingInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "AppointmentBooking");

            migrationBuilder.CreateTable(
                name: "Patients",
                schema: "AppointmentBooking",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SSN = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients",
                schema: "AppointmentBooking");
        }
    }
}
