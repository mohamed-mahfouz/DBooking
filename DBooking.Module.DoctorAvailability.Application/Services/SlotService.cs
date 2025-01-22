using AutoMapper;
using DBooking.Module.DoctorAvailability.Application.Dtos;
using DBooking.Module.DoctorAvailability.Infrastructure.Data.Entities;
using DBooking.Module.DoctorAvailability.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace DBooking.Module.DoctorAvailability.Application.Services
{
    public class SlotService(SlotRepository slotRepository, IMapper mapper)
    {
        private readonly SlotRepository _slotRepository = slotRepository;
        private readonly IMapper _mapper = mapper;


        public async Task<List<SlotDto>> GetMySlotsAsync(int pageNumber = 1, int maxCount = int.MaxValue)
        {
            var query = await _slotRepository.GetAll();

            var data = await query
                .Skip((1 - pageNumber) * maxCount)
                .Take(maxCount)
                .ToListAsync();

            return _mapper.Map<List<SlotDto>>(data);
        }
    }
}
