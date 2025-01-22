using Microsoft.AspNetCore.Mvc;

namespace DBooking.Modules.AppointmentBooking.Api.Controllers
{
    public class PatientAppointmentsController: BaseController
    {
        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok("DoctorAppointments APIs working well!");
        }
    }
}
