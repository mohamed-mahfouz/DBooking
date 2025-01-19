
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBooking.Modules.AppointmentBooking.Infrastructure.Data.Entities
{
    public class Patient
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public required string FirstName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public required string LastName { get; set; }

        [StringLength(14)]
        public string SSN { get; set; } = null!;

        [Range(0, 100)]
        public int Age { get; set; }
    }
}
