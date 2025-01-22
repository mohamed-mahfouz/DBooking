using DBooking.Module.DoctorAvailability.Infrastructure.Data;
using DBooking.Module.DoctorAvailability.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBooking.Module.DoctorAvailability.Infrastructure.Repositories
{
    public class SlotRepository(DoctorAvailabilityDbContext context)
    {
        private readonly DoctorAvailabilityDbContext _context = context;

        public async Task<IQueryable<Slot>> GetAll() => _context.Slots.AsNoTracking();

        public async Task<Slot> AddSlot(Slot slot)
        {
            var result = await _context.Slots.AddAsync(slot);
            await _context.SaveChangesAsync();

            return result.Entity;
        }
    }
}
