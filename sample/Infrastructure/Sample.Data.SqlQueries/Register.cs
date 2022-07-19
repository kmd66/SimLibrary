using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Data.SqlQueries
{
    public static class Register
    {
        public static IServiceCollection AddSqlQueriesService(this IServiceCollection services)
        {
            services.Scan(scan => scan.FromCallingAssembly()
            .AddClasses()
            .AsMatchingInterface()
            .WithTransientLifetime());

            return services;

        }
    }
}
