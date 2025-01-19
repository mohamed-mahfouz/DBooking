
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBooking.Modules.AppointmentBooking.Infrastructure.Data.Entities
{
    internal class Patient
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public required string FirstName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public required string LastName { get; set; }

        [Required]
        [StringLength(14)]
        public required string SSN { get; set; }

        [Range(0, 100)]
        public int Age { get; set; }
    }
}
