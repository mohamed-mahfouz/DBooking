using DBooking.Module.DoctorAvailability.Infrastructure.Data.Entities;
using DBooking.Shared.Databases;
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
        private Guid doctorId = DBHelper.DoctorId;
        public DbSet<Slot> Slots { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("DoctorAvailability");
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            // Seed data directly in the model
            modelBuilder.Entity<Slot>().HasData(
                new Slot { Id = Guid.NewGuid(), DoctorName = "Doctor 1", DoctorId = doctorId, Cost = 150, CreationDate = DateTime.UtcNow, Time = DateTime.UtcNow.AddDays(2) },
                new Slot { Id = Guid.NewGuid(), DoctorName = "Doctor 1", DoctorId = doctorId, Cost = 250, CreationDate = DateTime.UtcNow, Time = DateTime.UtcNow.AddDays(3) },
                new Slot { Id = Guid.NewGuid(), DoctorName = "Doctor 1", DoctorId = doctorId, Cost = 350, CreationDate = DateTime.UtcNow, Time = DateTime.UtcNow.AddDays(4) }
            );
        }
    }
}
