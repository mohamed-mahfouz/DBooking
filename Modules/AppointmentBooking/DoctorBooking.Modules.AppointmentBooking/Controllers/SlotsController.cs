using DBooking.Modules.AppointmentBooking.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DBooking.Modules.AppointmentBooking.Api.Controllers
{
    public class SlotsController(ISender sender): BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetAvialableSlots()
        {
            var result = await sender.Send(new GetAvailableSlotsQuery());
            return Ok(result);
        }
    }
}
