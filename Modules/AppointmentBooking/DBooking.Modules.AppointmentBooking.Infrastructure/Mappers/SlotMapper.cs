using DBooking.Modules.AppointmentBooking.Infrastructure.Data.Entities;
using DBooking.Shared.Entities;

namespace DBooking.Modules.AppointmentBooking.Infrastructure.Mappers
{
    internal static class SlotMapper
    {
        public static SlotEntity MapToEntity(Slot slot)
        {
            return new SlotEntity
            {
                Id = slot.Id,
                Cost = slot.Cost,
                Date = slot.Date,
                DoctorName = slot.DoctorName,
                DoctorId = slot.DoctorId,
                IsReserved = slot.IsReserved
            };
        }

        public static Slot MapToDbModel(SlotEntity slotEntity)
        {
            return new Slot
            {
                Id = slotEntity.Id,
                Cost = slotEntity.Cost,
                Date = slotEntity.Date,
                DoctorName = slotEntity.DoctorName,
                DoctorId = slotEntity.DoctorId,
                IsReserved = slotEntity.IsReserved
            };
        }
    }
}
