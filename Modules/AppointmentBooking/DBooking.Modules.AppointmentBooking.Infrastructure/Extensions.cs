using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using DBooking.Modules.AppointmentBooking.Infrastructure.Data;
using DBooking.Shared.Databases;


namespace DBooking.Modules.AppointmentBooking.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddAppointmentBookingInfra(this IServiceCollection services)
        {
            //services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlite("Data source=DBooking.db"));
            services.AddSQLServer<AppointmentBookingDbContext>("AppointmentBooking");
            return services;
        }

        public static IApplicationBuilder UseAppointmentBookingInfra(this IApplicationBuilder app) => app;
       
    }
}
