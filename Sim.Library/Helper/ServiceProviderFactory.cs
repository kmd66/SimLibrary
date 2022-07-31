using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Sim.Library.Helper
{
    public static class ServiceProviderFactory
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static void SetServiceProvider(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }
        public static T GetInstance<T>()
        {
            var instance = ServiceProvider.GetServices(typeof(T)).ToList();
            if (instance.Count > 0)
                return (T)instance[0];

            return default(T);
        }

        //public void SetServiceProvider(IServiceProvider serviceProvider) => _SetServiceProvider(serviceProvider);

        //public T GetInstance<T>() => _GetInstance<T>();
    }
}
