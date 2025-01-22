using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBooking.Module.DoctorAvailability.Application.Dtos
{
    public class AddSlotDto
    {
        public string DoctorName { get; set; }
        public DateTime Time { get; set; }
        public decimal Cost { get; set; }
    }
}
