using DBooking.Modules.AppointmentBooking.Application.DTOs;
using DBooking.Modules.DoctorAvailability.Shared.DTO;

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
