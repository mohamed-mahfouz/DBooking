using DBooking.Modules.AppointmentBooking.Application.DTOs;
using DBooking.Modules.AppointmentBooking.Application.Interfaces;
using DBooking.Modules.AppointmentBooking.Application.Mappers;
using MediatR;

namespace DBooking.Modules.AppointmentBooking.Application.Queries
{
    public record GetAvailableSlotsQuery(): IRequest<IEnumerable<SlotResponse>>;

    public class GetAvailableSlotsHandler(ISlotRepository slotRepository) : IRequestHandler<GetAvailableSlotsQuery, IEnumerable<SlotResponse>>
    {
        public async Task<IEnumerable<SlotResponse>> Handle(GetAvailableSlotsQuery request, CancellationToken cancellationToken)
        {
            var slots = await slotRepository.GetAvailableSlotsAsync();
            return slots?.Select(x => SlotMapper.MapToResponse(x)).ToList() ?? Enumerable.Empty<SlotResponse>();
        }
    }

}
