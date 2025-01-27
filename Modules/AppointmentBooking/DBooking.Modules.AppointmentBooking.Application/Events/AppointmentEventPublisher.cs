using DBooking.Modules.AppointmentBooking.Application.Interfaces;
using DBooking.Modules.AppointmentBooking.Shared.Events;

namespace DBooking.Modules.AppointmentBooking.Application.Events
{

    internal class AppointmentEventPublisher : IAppointmentEventPublisher
    {
        public event AppointmentCreatedEventHandler AppointmentCreated;

        public void TriggerAppointmentCreatedEvent(string patient,  DateTime appointmentDate)
        {
            OnAppointmentCreated(new AppointmentCreatedEventArgs(patient, appointmentDate));
        }

        protected virtual void OnAppointmentCreated(AppointmentCreatedEventArgs eventArgs)
        {
            //Raise event
            AppointmentCreated?.Invoke(eventArgs);
        }
       
    }
}
