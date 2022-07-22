using Microsoft.Extensions.DependencyInjection;
using Sim.Core.Connector;

namespace Sim.Helper
{
    public static class Register
    {
        public static IServiceCollection AddHelperService(this IServiceCollection services)
        {
            services.AddTransient<IMapService, AutoMapperPg>();
            return services;
        }
    }
}
