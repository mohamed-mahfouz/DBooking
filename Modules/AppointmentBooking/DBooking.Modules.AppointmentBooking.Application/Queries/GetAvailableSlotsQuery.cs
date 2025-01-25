using DBooking.Modules.AppointmentBooking.Application.DTOs;
using DBooking.Modules.AppointmentBooking.Application.Mappers;
using DBooking.Modules.DoctorAvailability.Shared;
using MediatR;

namespace DBooking.Modules.AppointmentBooking.Application.Queries
{
    public record GetAvailableSlotsQuery(): IRequest<IEnumerable<AvailableSlotResponse>>;

    public class GetAvailableSlotsHandler(IDoctorAvailabilityModuleApi doctorAvailabilityModuleApi) : IRequestHandler<GetAvailableSlotsQuery, IEnumerable<AvailableSlotResponse>>
    {
        public async Task<IEnumerable<AvailableSlotResponse>> Handle(GetAvailableSlotsQuery request, CancellationToken cancellationToken)
        {
            var allSlots =  await doctorAvailabilityModuleApi.GetMySlotsAsync();
         
            var availableSlots = allSlots.Where(x => !x.IsReserved)
                .Select(x => SlotMapper.MapToResponse(x))
                .ToList();

            return availableSlots;
        }
    }

}
