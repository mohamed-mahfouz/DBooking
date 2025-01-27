using DBooking.Modules.AppointmentBooking.Shared;
using DBooking.Modules.AppointmentBooking.Shared.Events;
using DBooking.Modules.AppointmentConfirmation.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DBooking.Modules.AppointmentConfirmation.Services.Services
{
    public class AppointmentNotificationService(IServiceProvider serviceProvider) : IHostedService
    {
        private INotificationService? notificationService;
        public Task StartAsync(CancellationToken cancellationToken)
        {
            using var scope = serviceProvider.CreateScope();

            this.notificationService = scope.ServiceProvider.GetRequiredService<INotificationService>();
            
            var AppointmentBookingModuleService = scope.ServiceProvider.GetRequiredService<IAppointmentBookingModuleApi>();
          
            AppointmentBookingModuleService.OnAppointmentCreatedEvent(OnAppointmentCreatedCallback);

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        private void OnAppointmentCreatedCallback(AppointmentCreatedEventArgs args) 
        {
            notificationService?.Send($"New appointment scheduled by {args.PatientName} at {args.AppointmentDate.ToLongDateString()}");
        }
    }
}
