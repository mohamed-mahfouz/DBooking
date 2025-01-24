using DBooking.Module.DoctorAvailability.Shared.DTO;

namespace DBooking.Module.DoctorAvailability.Shared
{
    public interface IDoctorAvailabilityModuleApi
    {
        Task<List<SlotSharedDto>> GetMySlotsAsync(int pageNumber = 1, int maxCount = int.MaxValue);
    }
}
