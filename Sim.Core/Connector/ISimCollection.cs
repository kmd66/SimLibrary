using Microsoft.Extensions.DependencyInjection;

namespace Sim.Core.Connector
{
    public interface ISimServiceCollection : IServiceCollection
    {
        System.IServiceProvider BuildServiceProvider();
        T GetRequiredService<T>();
    }
}
