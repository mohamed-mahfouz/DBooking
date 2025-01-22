using AutoMapper;
using DBooking.Module.DoctorAvailability.Application.Dtos;
using DBooking.Module.DoctorAvailability.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBooking.Module.DoctorAvailability.Application.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add mappings here
            CreateMap<Slot, SlotDto>();
            CreateMap<SlotDto, Slot>();
        }
    }
}
