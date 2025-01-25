using DBooking.Modules.AppointmentBooking.Application.Interfaces;
using DBooking.Modules.AppointmentBooking.Core.Entities;
using MediatR;

namespace DBooking.Modules.AppointmentBooking.Application.Queries
{
    public record GetUpcomingAppointmentQuery(): IRequest<IEnumerable<AppointmentEntity>>;

    public class GetUpcomingAppointmentHandler(IAppointmentRepository appointmentRepository) : IRequestHandler<GetUpcomingAppointmentQuery, IEnumerable<AppointmentEntity>>
    {
        public async Task<IEnumerable<AppointmentEntity>> Handle(GetUpcomingAppointmentQuery request, CancellationToken cancellationToken)
        {
            return await appointmentRepository.GetAllAppointmentsAsync();
        }
    }



}
