using DBooking.Modules.DoctorAvailability.Application.Dtos;
using DBooking.Modules.DoctorAvailability.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DBooking.Modules.DoctorAvailability.Api.Controllers
{
    public class SlotsController(SlotService slotService) : BaseController
    {
        private readonly SlotService _slotService = slotService;

        [HttpGet("GetMySlots")]
        public async Task<IActionResult> GetList(int pageNumber = 1, int maxCount = int.MaxValue)
            => Ok(await _slotService.GetMySlotsAsync(pageNumber, maxCount));

        [HttpPost("AddSlot")]
        public async Task<IActionResult> AddSlot(AddSlotDto addSlotDto) 
            => Ok(await _slotService.AddSlot(addSlotDto));

    }
}
