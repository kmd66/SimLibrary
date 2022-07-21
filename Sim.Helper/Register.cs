using Microsoft.Extensions.DependencyInjection;
using Sim.Core.Connector;

namespace Sim.Helper
{
    public static class Register
    {
        public static IServiceCollection AddHelperService(this IServiceCollection services)
        {
            services.AddScoped<IMapService, AutoMapperPg>();
            return services;
        }
    }
}
