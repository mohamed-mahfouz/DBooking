using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using DBooking.Modules.AppointmentBooking.Infrastructure.Data;
using DBooking.Shared.Databases;
using DBooking.Modules.AppointmentBooking.Application.Interfaces;
using DBooking.Modules.AppointmentBooking.Infrastructure.Repositories;


namespace DBooking.Modules.AppointmentBooking.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddAppointmentBookingInfra(this IServiceCollection services)
        {
            services.AddSQLServer<AppointmentBookingDbContext>("AppointmentBooking");
            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            return services;
        }

        public static IApplicationBuilder UseAppointmentBookingInfra(this IApplicationBuilder app) => app;
       
    }
}
