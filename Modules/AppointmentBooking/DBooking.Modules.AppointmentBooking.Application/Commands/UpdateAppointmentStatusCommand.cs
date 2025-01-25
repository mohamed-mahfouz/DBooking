using DBooking.Modules.AppointmentBooking.Application.Interfaces;
using DBooking.Modules.AppointmentBooking.Shared.Constants;
using MediatR;

namespace DBooking.Modules.AppointmentBooking.Application.Commands
{
    public record UpdateAppointmentStatusCommand(Guid AppointmentId, AppointmentStatus status): IRequest;

    public class UpdateAppointmentStatusHandler(IAppointmentRepository appointmentRepository) : IRequestHandler<UpdateAppointmentStatusCommand>
    {
        public async Task Handle(UpdateAppointmentStatusCommand request, CancellationToken cancellationToken)
        {
             await appointmentRepository.UpdateAppointmentStatus(request.AppointmentId, request.status);
        }
    }


}
