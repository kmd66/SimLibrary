using System;
using System.Collections.Generic;
using System.Text;

namespace Sim.Library.Connector
{
    public interface ISimServiceFactory
    {
        void SetServiceProvider(IServiceProvider serviceProvider);
        T GetInstance<T>();
    }
}
