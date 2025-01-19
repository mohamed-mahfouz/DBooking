using Microsoft.AspNetCore.Mvc;

namespace DBooking.Modules.AppointmentBooking.Api.Controllers
{
    public class PatientAppointmentsController: BaseController
    {
        public IActionResult Test()
        {
            return Ok("DoctorAppointments APIs working well!");
        }
    }
}
