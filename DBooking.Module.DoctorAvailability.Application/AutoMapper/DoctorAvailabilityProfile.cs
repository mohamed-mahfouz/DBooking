using AutoMapper;
using DBooking.Module.DoctorAvailability.Application.Dtos;
using DBooking.Module.DoctorAvailability.Infrastructure.Data.Entities;

namespace DBooking.Module.DoctorAvailability.Application.AutoMapper
{
    public class DoctorAvailabilityProfile : Profile
    {
        public DoctorAvailabilityProfile()
        {
            // Add mappings here
            CreateMap<Slot, SlotDto>();
            CreateMap<SlotDto, Slot>();

            CreateMap<AddSlotDto, Slot>();
        }
    }
}
