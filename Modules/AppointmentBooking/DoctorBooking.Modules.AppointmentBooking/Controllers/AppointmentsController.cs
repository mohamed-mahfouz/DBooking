using DBooking.Modules.AppointmentBooking.Application.Commands;
using DBooking.Modules.AppointmentBooking.Application.DTOs;
using DBooking.Modules.AppointmentBooking.Application.Queries;
using DBooking.Modules.AppointmentBooking.Application.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DBooking.Modules.AppointmentBooking.Api.Controllers
{
    public class AppointmentsController(ISender sender): BaseController
    {
        [HttpGet("available-slots")]
        public async Task<IActionResult> GetAvailableSlots()
        {
            IEnumerable<AvailableSlotResponse> result = await sender.Send(new GetAvailableSlotsQuery());
            return Ok(result);
        }

        [HttpGet("upcoming-appointments")]
        public async Task<IActionResult> GetAppointments()
        {
            var result = await sender.Send(new GetUpcomingAppointmentQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAppointment([FromBody] CreateAppointmentRequest request)
        {
            await sender.Send(new CreateAppointmentCommand(request));

            return CreatedAtAction(nameof(CreateAppointment), null);
        }
    }
}
