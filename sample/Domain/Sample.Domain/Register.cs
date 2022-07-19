﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Domain
{
    public static class Register
    {
        public static IServiceCollection AddDomainService(this IServiceCollection services)
        {

            services.Scan(scan => scan
            .FromAssemblyOf<Sim.Core.Model.IService>()
            .AddClasses(classes => classes.AssignableTo< Sim.Core.Model.Service> ())
            .AsSelf()
            .WithTransientLifetime());

            return services;
        }
    }
}
