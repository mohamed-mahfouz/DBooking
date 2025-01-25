using DBooking.Modules.AppointmentBooking.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DBooking.Modules.AppointmentBooking.Infrastructure.Data
{
    public class AppointmentBookingDbContext(DbContextOptions<AppointmentBookingDbContext> options) : DbContext(options)
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("AppointmentBooking");
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
