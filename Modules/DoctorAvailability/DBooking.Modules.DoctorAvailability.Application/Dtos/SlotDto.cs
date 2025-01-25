namespace DBooking.Modules.DoctorAvailability.Application.Dtos
{
    public class SlotDto
    {
        public Guid Id { get; set; }
        public Guid DoctorId { get; set; }
        public string DoctorName { get; set; } = null!;
        public bool IsReserved { get; set; }
        public decimal Cost { get; set; }
        public DateTime Time { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.UtcNow;
    }
}
