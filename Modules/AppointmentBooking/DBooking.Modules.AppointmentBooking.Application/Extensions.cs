
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DoctorBooking.Modules.AppointmentBooking.Application
{
    public static class Extensions
    {
        //Register as service
        public static IServiceCollection AddAppointmentBookingApplication(this IServiceCollection services)
        {
            services.AddMediatR(opt => opt.RegisterServicesFromAssembly(typeof(Extensions).Assembly));
            return services;
        }

        //Register as middleware
        public static IApplicationBuilder UseAppointmentBookingApplication(this IApplicationBuilder app)
        {

            return app;
        }
    }
}
