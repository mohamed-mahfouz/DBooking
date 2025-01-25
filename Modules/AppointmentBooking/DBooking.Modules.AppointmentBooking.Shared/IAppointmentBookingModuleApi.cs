using DBooking.Modules.AppointmentBooking.Shared.Constants;
using DBooking.Modules.AppointmentBooking.Shared.DTO;

namespace DBooking.Modules.AppointmentBooking.Shared
{
    public interface IAppointmentBookingModuleApi
    {
        Task<IEnumerable<GetAppointmentSharedDto>> GetUpcomingAppointments();
        Task UpdateAppointmentStatus(Guid appointmentId, AppointmentStatus status);
    }
}
