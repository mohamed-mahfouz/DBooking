using DBooking.Modules.AppointmentBooking.Core.Entities;
using DBooking.Modules.AppointmentBooking.Infrastructure.Data.Entities;

namespace DBooking.Modules.AppointmentBooking.Infrastructure.Mappers
{
    internal static class AppointmentMapper
    {
        public static AppointmentEntity MapToEntity(Appointment appointment)
        {
            return new AppointmentEntity
            {
                Id = appointment.Id,
                PatientId = appointment.PatientId,
                ReservedAt = appointment.ReservedAt,
                SlotId = appointment.SlotId 
            };
        }

        public static Appointment MapToDbModel(AppointmentEntity appointmentEntity)
        {
            return new Appointment
            {
                Id = appointmentEntity.Id,
                PatientId = appointmentEntity.PatientId,
                ReservedAt = appointmentEntity.ReservedAt,
                SlotId = appointmentEntity.SlotId
            };
        }
    }
}
