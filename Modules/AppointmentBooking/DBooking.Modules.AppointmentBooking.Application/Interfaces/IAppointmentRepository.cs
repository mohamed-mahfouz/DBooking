using DBooking.Modules.AppointmentBooking.Core.Entities;
using DBooking.Modules.AppointmentBooking.Shared.Constants;

namespace DBooking.Modules.AppointmentBooking.Application.Interfaces
{
    public interface IAppointmentRepository
    {
       Task CreateAppointment(AppointmentEntity appointment);
       Task UpdateAppointmentStatus(Guid appointmentId, AppointmentStatus status);
       Task<IEnumerable<AppointmentEntity>> GetAllAppointmentsAsync();

    }
}
