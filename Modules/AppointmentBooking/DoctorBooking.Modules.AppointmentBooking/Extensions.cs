
using DBooking.Modules.AppointmentBooking.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DoctorBooking.Modules.AppointmentBooking.Api
{
    public static class Extensions
    {
        //Register as service
        public static IServiceCollection AddAppointmentBookingModule(this IServiceCollection services)
        {
            services.AddAppointmentBookingInfra();

            return services;
        }

        //Register as middleware
        public static IApplicationBuilder UseAppointmentBookingModule(this IApplicationBuilder app) => app;
       
    }
}
