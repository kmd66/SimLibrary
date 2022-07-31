using Sim.Library.Helper;
using System;

namespace Sim.Library.Model
{
    public abstract class Service
    {
        protected Service()
        {
        }
    }
    public class Service<IDataQueries> : Service
    {
        protected Service() : base()
        {
            if (_queries == null)
                _queries = ServiceProviderFactory.GetInstance<IDataQueries>();
        }
        protected readonly IDataQueries _queries;
    }
}
