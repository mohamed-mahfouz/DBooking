namespace DBooking.Modules.AppointmentBooking.Core.Entities
{
    public class AppointmentEntity
    {
        public Guid Id { get; set; }
        public Guid SlotId { get; set; }
        public Guid PatientId { get; set; }
        public string PatientName { get; set; } = null!;
        public DateTime ReservedAt { get; set; }
        public int Status { get; set; }
    }
}
