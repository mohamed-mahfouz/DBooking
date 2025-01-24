using DBooking.Modules.AppointmentBooking.Core.Entities;

namespace DBooking.Modules.AppointmentBooking.Application.Interfaces
{
    public interface IAppointmentRepository
    {
       Task CreateAppointment(AppointmentEntity appointment);
       Task<IEnumerable<AppointmentEntity>> GetAllAppointmentsAsync(AppointmentEntity appointment);

    }
}
