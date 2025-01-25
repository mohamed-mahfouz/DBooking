using DBooking.Modules.AppointmentBooking.Core.Entities;
using DBooking.Modules.AppointmentBooking.Shared.DTO;

namespace DBooking.Modules.AppointmentBooking.Application.Mappers
{
    public static class AppointmentMapper
    {
       public static GetAppointmentSharedDto MapToSharedDto(AppointmentEntity appointmentEntity)
       {
            return new GetAppointmentSharedDto
            {
                AppointmentId = appointmentEntity.Id,
                PatientName = appointmentEntity.PatientName,
                AppointmentDate = appointmentEntity.ReservedAt             
            };
       }
    }
}
