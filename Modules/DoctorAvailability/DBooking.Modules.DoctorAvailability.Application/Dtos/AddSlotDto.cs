namespace DBooking.Modules.DoctorAvailability.Application.Dtos
{
    public class AddSlotDto
    {
        public string DoctorName { get; set; }
        public DateTime Time { get; set; }
        public decimal Cost { get; set; }
    }
}
