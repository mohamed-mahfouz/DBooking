using DBooking.Modules.AppointmentBooking.Shared.Constants;
using DBooking.Modules.AppointmentBooking.Shared.DTO;
using DBooking.Modules.AppointmentBooking.Shared.Events;

namespace DBooking.Modules.AppointmentBooking.Shared
{
    public interface IAppointmentBookingModuleApi
    {
        Task<IEnumerable<GetAppointmentSharedDto>> GetUpcomingAppointments();
        Task UpdateAppointmentStatus(Guid appointmentId, AppointmentStatus status);
        void OnAppointmentCreatedEvent(AppointmentCreatedEventHandler appointmentCreatedCallback);
    }
}
