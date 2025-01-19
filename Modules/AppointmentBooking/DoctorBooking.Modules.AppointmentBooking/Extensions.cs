
using DBooking.Modules.AppointmentBooking.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DoctorBooking.Modules.AppointmentBooking.Api
{
    public static class Extensions
    {
        public static IServiceCollection AddAppointmentBookingModule(this IServiceCollection services)
        {
            services.AddAppointmentBookingInfra();

            return services;
        }

        public static IApplicationBuilder UseAppointmentBookingModule(this IApplicationBuilder app)
        {

            return app;
        }
    }
}
