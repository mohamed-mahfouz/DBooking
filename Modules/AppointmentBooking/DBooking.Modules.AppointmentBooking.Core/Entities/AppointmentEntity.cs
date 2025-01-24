namespace DBooking.Modules.AppointmentBooking.Core.Entities
{
    public class AppointmentEntity
    {
        public Guid Id { get; set; }
        public Guid SlotId { get; set; }
        public Guid PatientId { get; set; }
        public DateTime ReservedAt { get; set; }
    }
}
