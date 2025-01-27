namespace DBooking.Modules.AppointmentBooking.Shared.Events
{
    public delegate void AppointmentCreatedEventHandler(AppointmentCreatedEventArgs eventArgs);

    public class AppointmentCreatedEventArgs : EventArgs
    {
        public string PatientName { get; }
        public DateTime AppointmentDate { get; }

        public AppointmentCreatedEventArgs(string patientName, DateTime appointmentDate)
        {
            PatientName = patientName;
            AppointmentDate = appointmentDate;
        }
    }
}
