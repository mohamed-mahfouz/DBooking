using DBooking.Modules.AppointmentBooking.Shared.Constants;
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
        public string? PatientName { get; set; }
        public DateTime ReservedAt { get; set; }
        public int Status { get; set; } = (int)AppointmentStatus.Scheduled;

        [ForeignKey(nameof(PatientId))]
        public IEnumerable<Patient> Patients { get; set; } = null!;
    }
}
