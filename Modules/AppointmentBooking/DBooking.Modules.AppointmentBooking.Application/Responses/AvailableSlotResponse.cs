namespace DBooking.Modules.AppointmentBooking.Application.DTOs
{
    public class AvailableSlotResponse
    {      
        public DateTime Date { get; set; }
        public string DoctorName { get; set; } = null!;
        public decimal Cost { get; set; }

    }
}
