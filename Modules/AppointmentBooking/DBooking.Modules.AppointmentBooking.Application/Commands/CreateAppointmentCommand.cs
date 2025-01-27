using DBooking.Modules.AppointmentBooking.Application.Interfaces;
using DBooking.Modules.AppointmentBooking.Application.Requests;
using DBooking.Modules.AppointmentBooking.Core.Entities;
using MediatR;

namespace DBooking.Modules.AppointmentBooking.Application.Commands
{
    public record CreateAppointmentCommand(CreateAppointmentRequest Request) : IRequest;

    public class CreateAppointmentHandler(IAppointmentRepository appointmentRepository, IAppointmentEventPublisher appointmentEventPublisher) : IRequestHandler<CreateAppointmentCommand>
    {
        public async Task Handle(CreateAppointmentCommand command, CancellationToken cancellationToken)
        {
            var newAppointment = new AppointmentEntity()
            {
                Id = Guid.NewGuid(),
                PatientId = command.Request.PatientId,
                ReservedAt = command.Request.ReservedAt,
                SlotId = command.Request.SlotId,
            };

           await appointmentRepository.CreateAppointment(newAppointment);

          appointmentEventPublisher.TriggerAppointmentCreatedEvent(newAppointment.PatientName, newAppointment.ReservedAt);
        }
    }


}
