﻿using DBooking.Modules.AppointmentBooking.Application.Interfaces;
using DBooking.Modules.AppointmentBooking.Core.Entities;
using DBooking.Modules.AppointmentBooking.Infrastructure.Data;
using DBooking.Modules.AppointmentBooking.Infrastructure.Data.Mappers;
using DBooking.Modules.AppointmentBooking.Shared.Constants;
using Microsoft.EntityFrameworkCore;

namespace DBooking.Modules.AppointmentBooking.Infrastructure.Repositories
{
    internal class AppointmentRepository(AppointmentBookingDbContext context) : IAppointmentRepository
    {

        public async Task CreateAppointment(AppointmentEntity appointmentEntity)
        {
            
            var appointment = AppointmentMapper.MapToDbModel(appointmentEntity);
            context.Appointments.Add(appointment);

            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<AppointmentEntity>> GetAllAppointmentsAsync()
        {
            var appointments = await context.Appointments.Select(x => AppointmentMapper.MapToEntity(x)).ToListAsync();
            return appointments;
        }

        public async Task UpdateAppointmentStatus(Guid appointmentId, AppointmentStatus status)
        {
            var appointment = await context.Appointments.FirstOrDefaultAsync(x => x.Id == appointmentId);

            if(appointment != null)
            {
                appointment.Status = (int)status;
                await context.SaveChangesAsync();
            }
        }
    }
}
