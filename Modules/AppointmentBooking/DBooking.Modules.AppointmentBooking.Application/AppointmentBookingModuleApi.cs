using DBooking.Modules.AppointmentBooking.Application.Commands;
using DBooking.Modules.AppointmentBooking.Application.Events;
using DBooking.Modules.AppointmentBooking.Application.Interfaces;
using DBooking.Modules.AppointmentBooking.Application.Mappers;
using DBooking.Modules.AppointmentBooking.Application.Queries;
using DBooking.Modules.AppointmentBooking.Shared;
using DBooking.Modules.AppointmentBooking.Shared.Constants;
using DBooking.Modules.AppointmentBooking.Shared.DTO;
using DBooking.Modules.AppointmentBooking.Shared.Events;
using MediatR;

namespace DBooking.Modules.AppointmentBooking.Application
{
    public class AppointmentBookingModuleApi(ISender sender, IAppointmentEventPublisher appointmentEventPublisher) : IAppointmentBookingModuleApi
    {
        public async Task<IEnumerable<GetAppointmentSharedDto>> GetUpcomingAppointments()
        {
           var upcomingAppointments =  await sender.Send(new GetUpcomingAppointmentQuery());
           var result = upcomingAppointments.Select(x => AppointmentMapper.MapToSharedDto(x)).ToList();

           return result;
        }

        public async Task UpdateAppointmentStatus(Guid appointmentId, AppointmentStatus status)
        {
            await sender.Send(new UpdateAppointmentStatusCommand(appointmentId, status));      
        }

       public void OnAppointmentCreatedEvent(AppointmentCreatedEventHandler appointmentCreatedCallback)
       {
            appointmentEventPublisher.AppointmentCreated += appointmentCreatedCallback;
       }
       
    }
}
