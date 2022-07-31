using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Sim.Library.Connector;
using Sim.Library.Helper;
using System;

namespace Sim.Library
{
    public static class Register
    {
        public static IServiceCollection AddHelperService(this IServiceCollection services)
        {
            services.AddTransient<IMapService, AutoMapperPg>();
            //services.AddTransient<ISimServiceFactory, ServiceProviderFactory>();
            return services;
        }
        public static IServiceCollection SetServiceProvider(this IServiceCollection services, IServiceProvider serviceProvider)
        {
            ServiceProviderFactory.SetServiceProvider(serviceProvider);
            return services;
        }
    }
}
