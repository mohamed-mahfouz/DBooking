using AutoMapper;
using DBooking.Module.DoctorAvailability.Application.Dtos;
using DBooking.Module.DoctorAvailability.Infrastructure.Data.Entities;
using DBooking.Module.DoctorAvailability.Shared.DTO;

namespace DBooking.Module.DoctorAvailability.Application.AutoMapper
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
