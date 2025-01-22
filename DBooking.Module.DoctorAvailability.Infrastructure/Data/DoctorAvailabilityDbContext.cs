using DBooking.Module.DoctorAvailability.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DBooking.Module.DoctorAvailability.Infrastructure.Data
{
    public class DoctorAvailabilityDbContext(DbContextOptions<DoctorAvailabilityDbContext> options) : DbContext(options)
    {
        public DbSet<Slot> Slots { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("DoctorAvailability");
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
