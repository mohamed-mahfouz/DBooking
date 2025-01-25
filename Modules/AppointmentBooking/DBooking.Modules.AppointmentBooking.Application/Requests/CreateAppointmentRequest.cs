using System.ComponentModel.DataAnnotations;

namespace DBooking.Modules.AppointmentBooking.Application.Requests
{
    public class CreateAppointmentRequest
    {
        [Required]
        public Guid PatientId { get; set; }
      
        [Required]
        public Guid SlotId { get; set; }
       
        public DateTime ReservedAt => DateTime.UtcNow;
    }
}
