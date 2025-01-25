using DBooking.Module.DoctorAvailability.Shared.DTO;
using DBooking.Modules.AppointmentBooking.Application.DTOs;

namespace DBooking.Modules.AppointmentBooking.Application.Mappers
{
    internal static class SlotMapper
    {
        public static AvailableSlotResponse MapToResponse(SlotSharedDto slotDto)
        {
            return new AvailableSlotResponse
            {
                Cost = slotDto.Cost,
                Date = slotDto.Time,
                DoctorName = slotDto.DoctorName,
            };
        }
    }
}
