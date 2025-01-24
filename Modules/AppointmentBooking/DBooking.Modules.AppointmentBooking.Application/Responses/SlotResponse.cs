namespace DBooking.Modules.AppointmentBooking.Application.DTOs
{
    public class SlotResponse
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public Guid DoctorId { get; set; }
        public string DoctorName { get; set; } = null!;
        public bool IsReserved { get; set; }
        public decimal Cost { get; set; }

    }
}
