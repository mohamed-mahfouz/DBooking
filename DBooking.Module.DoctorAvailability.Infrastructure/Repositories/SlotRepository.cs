using DBooking.Module.DoctorAvailability.Infrastructure.Data;
using DBooking.Module.DoctorAvailability.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DBooking.Module.DoctorAvailability.Infrastructure.Repositories
{
    public class SlotRepository(DoctorAvailabilityDbContext context)
    {
        private readonly DoctorAvailabilityDbContext _context = context;

        public async Task<IEnumerable<Slot>> GetAll(int pageNumber = 1, int maxCount = int.MaxValue)
        {
            return await _context.Slots
                                 .AsNoTracking()
                                 .OrderByDescending(x => x.CreationDate)
                                 .Skip((1 - pageNumber) * maxCount)
                                 .Take(maxCount)
                                 .ToListAsync();
        }


        public async Task<Slot> AddSlot(Slot slot)
        {
            var result = await _context.Slots.AddAsync(slot);
            await _context.SaveChangesAsync();

            return result.Entity;
        }
    }
}
