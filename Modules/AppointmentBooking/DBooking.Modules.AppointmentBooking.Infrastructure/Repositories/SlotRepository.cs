using DBooking.Modules.AppointmentBooking.Application.Interfaces;
using DBooking.Modules.AppointmentBooking.Infrastructure.Data;
using DBooking.Modules.AppointmentBooking.Infrastructure.Mappers;
using DBooking.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace DBooking.Modules.AppointmentBooking.Infrastructure.Repositories
{
    public class SlotRepository(AppointmentBookingDbContext context) : ISlotRepository
    {
        public async Task CreateSlotAsync(SlotEntity slotEntity)
        {
           var slot = SlotMapper.MapToDbModel(slotEntity);
           context.Slots.Add(slot);
           
           await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<SlotEntity>> GetAvailableSlotsAsync()
        {
            var availableSlots = await context.Slots.Where(slot => !slot.IsReserved).Select(slot => SlotMapper.MapToEntity(slot)).ToListAsync();
            return availableSlots;
        }
    }
}
