using DBooking.Modules.AppointmentBooking.Shared;
using DBooking.Modules.AppointmentBooking.Shared.Constants;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DBooking.Modules.AppointmentManagement.Internal.Shell.Controllers
{
    public class AppointmentManagementsController(IAppointmentBookingModuleApi appointmentBookingModuleApi) : BaseController
    {
        private readonly IAppointmentBookingModuleApi _appointmentBookingModuleApi = appointmentBookingModuleApi;

        [HttpGet("GetUpcomingAppointments")]
        public async Task<IActionResult> GetUpcomingAppointments()
            => Ok(await _appointmentBookingModuleApi.GetUpcomingAppointments());

        [HttpPatch("UpdateAppointmentStatus")]
        public async Task<IActionResult> UpdateAppointmentStatus(Guid appointmentId, AppointmentStatus status)
           => Ok(_appointmentBookingModuleApi.UpdateAppointmentStatus(appointmentId, status));

    }
}
