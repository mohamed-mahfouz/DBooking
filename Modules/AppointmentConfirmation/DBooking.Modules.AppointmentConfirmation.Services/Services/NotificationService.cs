using DBooking.Modules.AppointmentConfirmation.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace DBooking.Modules.AppointmentConfirmation.Services.Services
{
    public class NotificationService(ILogger<NotificationService> logger) : INotificationService
    {
        public void Send(string message)
        {
            logger.LogInformation(message);
        }
    }
}
