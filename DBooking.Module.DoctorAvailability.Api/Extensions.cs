using DBooking.Module.DoctorAvailability.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBooking.Module.DoctorAvailability.Api
{
    public static class Extensions
    {
        //Register as service
        public static IServiceCollection AddDoctorAvailabilityModule(this IServiceCollection services)
        {
            services.AddDoctorAvailabilityInfra();
            return services;
        }

        //Register as middleware
        public static IApplicationBuilder UseDoctorAvailabilityModule(this IApplicationBuilder app) => app;
      
    }
}
