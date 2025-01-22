using DBooking.Module.DoctorAvailability.Application.Dtos;
using DBooking.Module.DoctorAvailability.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBooking.Module.DoctorAvailability.Api.Controllers
{
    public class SlotsController(SlotService slotService) : BaseController
    {
        private readonly SlotService _slotService = slotService;

        [HttpGet("Slots")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetList() => Ok(await _slotService.GetMySlotsAsync());

    }
}
