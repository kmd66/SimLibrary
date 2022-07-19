using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Model.Data
{
    public static class Register
    {
        public static IServiceCollection AddDbService(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<PblContexts>(options =>
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Sample;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));

            return services;

        }
    }
}
