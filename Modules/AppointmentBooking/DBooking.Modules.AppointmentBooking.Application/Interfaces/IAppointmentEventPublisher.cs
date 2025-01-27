using DBooking.Modules.AppointmentBooking.Application.Events;
using DBooking.Modules.AppointmentBooking.Shared.Events;

namespace DBooking.Modules.AppointmentBooking.Application.Interfaces
{
    public interface IAppointmentEventPublisher
    {
        void TriggerAppointmentCreatedEvent(string patient, DateTime appointmentDate);

        event AppointmentCreatedEventHandler AppointmentCreated;
    }
}
