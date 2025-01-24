using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBooking.Modules.AppointmentBooking.Core.Entities
{
    public class PatientEntity
    {
        public Guid Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string SSN { get; set; } = null!;
        public int Age { get; set; }
    }
}
