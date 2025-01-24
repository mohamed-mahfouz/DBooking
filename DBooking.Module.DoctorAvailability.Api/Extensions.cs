using DBooking.Module.DoctorAvailability.Application.AutoMapper;
using DBooking.Module.DoctorAvailability.Application.Services;
using DBooking.Module.DoctorAvailability.Infrastructure;
using DBooking.Module.DoctorAvailability.Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DBooking.Module.DoctorAvailability.Api
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


            //others
            services.AddAutoMapper(typeof(DoctorAvailabilityProfile));

            return services;
        }

        //Register as middleware
        public static IApplicationBuilder UseDoctorAvailabilityModule(this IApplicationBuilder app) => app;
      
    }
}
