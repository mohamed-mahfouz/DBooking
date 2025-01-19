using DBooking.Modules.AppointmentBooking.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DBooking.Modules.AppointmentBooking.Infrastructure.Data
{
    public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Patient> Patients { get; set; }
    }
}
