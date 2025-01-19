using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using DBooking.Modules.AppointmentBooking.Infrastructure.Data;


namespace DBooking.Modules.AppointmentBooking.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddAppointmentBookingInfra(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlite("Data source=DBooking.db"));
           
            return services;
        }

        public static IApplicationBuilder UseAppointmentBookingInfra(this IApplicationBuilder app)
        {

            return app;
        }
    }
}
