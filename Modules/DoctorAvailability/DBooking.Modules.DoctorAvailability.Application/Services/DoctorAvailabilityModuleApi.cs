using AutoMapper;
using DBooking.Modules.DoctorAvailability.Infrastructure.Repositories;
using DBooking.Modules.DoctorAvailability.Shared;
using DBooking.Modules.DoctorAvailability.Shared.DTO;

namespace DBooking.Modules.DoctorAvailability.Application.Services
{
    public class DoctorAvailabilityModuleApi(SlotRepository slotRepository, IMapper mapper) : IDoctorAvailabilityModuleApi
    {
        private readonly SlotRepository _slotRepository = slotRepository;
        private readonly IMapper _mapper = mapper;

        public async Task<List<SlotSharedDto>> GetMySlotsAsync(int pageNumber = 1, int maxCount = int.MaxValue)
        {
            var data = await _slotRepository.GetAll();
            return _mapper.Map<List<SlotSharedDto>>(data);
        }
    }
}
