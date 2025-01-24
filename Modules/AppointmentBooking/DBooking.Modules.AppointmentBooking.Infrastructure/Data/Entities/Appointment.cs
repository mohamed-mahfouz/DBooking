using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBooking.Modules.AppointmentBooking.Infrastructure.Data.Entities
{
    public class Appointment
    {
        [Key]
        public Guid Id { get; set; }      
        public Guid SlotId { get; set; }
        public Guid PatientId { get; set; }
        public DateTime ReservedAt { get; set; }

        [ForeignKey(nameof(PatientId))]
        public IEnumerable<Patient> Patients { get; set; } = null!;
    }
}
