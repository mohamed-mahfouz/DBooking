using DBooking.Modules.DoctorAvailability.Infrastructure.Data;
using DBooking.Shared.Databases;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DBooking.Modules.DoctorAvailability.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddDoctorAvailabilityInfra(this IServiceCollection services)
        {
            services.AddSQLServer<DoctorAvailabilityDbContext>("DoctorAvailability");

            return services;
        }

        public static IApplicationBuilder UseDoctorAvailabilityInfra(this IApplicationBuilder app) => app;
        
    }
}
