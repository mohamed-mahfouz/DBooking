using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBooking.Modules.AppointmentBooking.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateAppointmentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PatientId",
                schema: "AppointmentBooking",
                table: "Patients",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Appointments",
                schema: "AppointmentBooking",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SlotId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReservedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_PatientId",
                schema: "AppointmentBooking",
                table: "Patients",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Appointments_PatientId",
                schema: "AppointmentBooking",
                table: "Patients",
                column: "PatientId",
                principalSchema: "AppointmentBooking",
                principalTable: "Appointments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Appointments_PatientId",
                schema: "AppointmentBooking",
                table: "Patients");

            migrationBuilder.DropTable(
                name: "Appointments",
                schema: "AppointmentBooking");

            migrationBuilder.DropIndex(
                name: "IX_Patients_PatientId",
                schema: "AppointmentBooking",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PatientId",
                schema: "AppointmentBooking",
                table: "Patients");
        }
    }
}
