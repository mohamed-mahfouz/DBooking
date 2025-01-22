using DBooking.Module.DoctorAvailability.Infrastructure.Data;
using DBooking.Shared.Databases;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DBooking.Module.DoctorAvailability.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddDoctorAvailabilityInfra(this IServiceCollection services)
        {
            //services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlite("Data source=DBooking.db"));
            services.AddSQLServer<DoctorAvailabilityDbContext>("DoctorAvailability");

            return services;
        }

        public static IApplicationBuilder UseDoctorAvailabilityInfra(this IApplicationBuilder app) => app;
        
    }
}
