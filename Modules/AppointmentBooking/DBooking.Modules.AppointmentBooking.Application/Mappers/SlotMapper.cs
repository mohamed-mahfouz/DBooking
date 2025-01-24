using DBooking.Modules.AppointmentBooking.Application.DTOs;
using DBooking.Shared.Entities;

namespace DBooking.Modules.AppointmentBooking.Application.Mappers
{
    internal static class SlotMapper
    {
        public static SlotResponse MapToResponse(SlotEntity slotEntity)
        {
            return new SlotResponse
            {
                Id = slotEntity.Id,
                Cost = slotEntity.Cost,
                Date = slotEntity.Date,
                DoctorId = slotEntity.DoctorId,
                DoctorName = slotEntity.DoctorName,
                IsReserved = slotEntity.IsReserved
            };
        }
    }
}
