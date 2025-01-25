using DBooking.Modules.DoctorAvailability.Shared.DTO;

namespace DBooking.Modules.DoctorAvailability.Shared
{
    public interface IDoctorAvailabilityModuleApi
    {
        Task<List<SlotSharedDto>> GetMySlotsAsync(int pageNumber = 1, int maxCount = int.MaxValue);
    }
}
