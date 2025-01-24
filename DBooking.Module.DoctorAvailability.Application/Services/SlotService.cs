using AutoMapper;
using DBooking.Module.DoctorAvailability.Application.Dtos;
using DBooking.Module.DoctorAvailability.Infrastructure.Data.Entities;
using DBooking.Module.DoctorAvailability.Infrastructure.Repositories;
using DBooking.Shared.Databases;

namespace DBooking.Module.DoctorAvailability.Application.Services
{
    public class SlotService(SlotRepository slotRepository, IMapper mapper)
    {
        private readonly SlotRepository _slotRepository = slotRepository;
        private readonly IMapper _mapper = mapper;

        public async Task<List<SlotDto>> GetMySlotsAsync(int pageNumber = 1, int maxCount = int.MaxValue)
        {
            var query = await _slotRepository.GetAll(pageNumber, maxCount);

            var data = query.ToList();
            return _mapper.Map<List<SlotDto>>(data);
        }

        public async Task<SlotDto> AddSlot(AddSlotDto addSlotDto)
        {
            var slot = _mapper.Map<Slot>(addSlotDto);
            slot.DoctorId = DBHelper.DoctorId;

            var query = await _slotRepository.AddSlot(slot);
            return _mapper.Map<SlotDto>(query);
        }
    }
}
