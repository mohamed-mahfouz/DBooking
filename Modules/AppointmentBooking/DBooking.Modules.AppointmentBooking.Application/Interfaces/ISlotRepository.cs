using DBooking.Shared.Entities;

namespace DBooking.Modules.AppointmentBooking.Application.Interfaces
{
    public interface ISlotRepository
    {
        public Task<IEnumerable<SlotEntity>> GetAvailableSlotsAsync();        
        public Task CreateSlotAsync(SlotEntity slot);

    }
}
