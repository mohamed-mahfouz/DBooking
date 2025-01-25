using AutoMapper;
using DBooking.Modules.DoctorAvailability.Application.Dtos;
using DBooking.Modules.DoctorAvailability.Infrastructure.Data.Entities;
using DBooking.Modules.DoctorAvailability.Shared.DTO;

namespace DBooking.Modules.DoctorAvailability.Application.AutoMapper
{
    public class DoctorAvailabilityProfile : Profile
    {
        public DoctorAvailabilityProfile()
        {
            // Add mappings here
            CreateMap<Slot, SlotDto>();
            CreateMap<Slot, SlotSharedDto>();
            CreateMap<SlotDto, Slot>();

            CreateMap<AddSlotDto, Slot>();
        }
    }
}
