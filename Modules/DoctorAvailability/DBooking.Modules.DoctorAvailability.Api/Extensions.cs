using DBooking.Modules.DoctorAvailability.Application.AutoMapper;
using DBooking.Modules.DoctorAvailability.Application.Services;
using DBooking.Modules.DoctorAvailability.Infrastructure;
using DBooking.Modules.DoctorAvailability.Infrastructure.Repositories;
using DBooking.Modules.DoctorAvailability.Shared;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DBooking.Modules.DoctorAvailability.Api
{
    public static class Extensions
    {
        //Register as service
        public static IServiceCollection AddDoctorAvailabilityModule(this IServiceCollection services)
        {
            //register database
            services.AddDoctorAvailabilityInfra();

            //register services
            services.AddScoped<SlotService>();
            services.AddScoped<SlotRepository>();
            services.AddScoped<IDoctorAvailabilityModuleApi, DoctorAvailabilityModuleApi>();

            //others
            services.AddAutoMapper(typeof(DoctorAvailabilityProfile));

            return services;
        }

        //Register as middleware
        public static IApplicationBuilder UseDoctorAvailabilityModule(this IApplicationBuilder app) => app;
      
    }
}
