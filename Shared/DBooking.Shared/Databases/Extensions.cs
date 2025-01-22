using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBooking.Shared.Databases
{
    public static class Extensions
    {
        private const string SectionName = "ConnectionStrings";

        internal static IServiceCollection AddSQLServer(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<SQLServerOptions>(configuration.GetSection(SectionName));
            services.AddHostedService<DbContextAppInitializer>();

            return services;
        }


        public static IServiceCollection AddSQLServer<T>(this IServiceCollection services, string schema) where T : DbContext
        {
            // builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            var configuration = services.BuildServiceProvider().GetRequiredService<IConfiguration>();
            var connectionString = configuration[$"{SectionName}:{nameof(SQLServerOptions.DefaultConnection)}"];

            services.AddDbContext<T>(x => x.UseSqlServer(
                connectionString,
                x => x.MigrationsHistoryTable(HistoryRepository.DefaultTableName, schema)));

            return services;
        }
    }
}
