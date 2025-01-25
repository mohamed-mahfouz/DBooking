namespace DBooking.Modules.AppointmentBooking.Shared.DTO
{
    public class GetAppointmentSharedDto
    {
        public Guid AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public required string PatientName { get; set; } 
    }
}
