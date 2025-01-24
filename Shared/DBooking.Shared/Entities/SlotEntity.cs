namespace DBooking.Shared.Entities
{
    public class SlotEntity
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public Guid DoctorId { get; set; }
        public string DoctorName { get; set; } = null!;
        public bool IsReserved { get; set; }
        public decimal Cost { get; set; }

    }
}
