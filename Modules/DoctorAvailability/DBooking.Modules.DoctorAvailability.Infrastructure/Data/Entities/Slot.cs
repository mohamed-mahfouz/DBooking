using System.ComponentModel.DataAnnotations;

namespace DBooking.Modules.DoctorAvailability.Infrastructure.Data.Entities
{
    public class Slot
    {
        [Key]
        public Guid Id { get; set; }
        public Guid DoctorId { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string DoctorName { get; set; }
        public bool IsReserved { get; set; }
        public decimal Cost { get; set; }
        public DateTime Time { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.UtcNow;

    }
}
