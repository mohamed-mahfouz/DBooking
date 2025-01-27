
using DBooking.Modules.AppointmentConfirmation.Services.Interfaces;
using DBooking.Modules.AppointmentConfirmation.Services.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DoctorBooking.Modules.AppointmentConfirmation.Api
{
    public static class Extensions
    {
        //Register as service
        public static IServiceCollection AddAppointmentConfirmationModule(this IServiceCollection services)
        {
            services.AddSingleton<INotificationService, NotificationService>()
                    .AddHostedService<AppointmentNotificationService>();

            return services;
        }

        //Register as middleware
        public static IApplicationBuilder UseAppointmentConfirmationModule(this IApplicationBuilder app) => app;
       
    }
}
