using Sim.Library.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Api
{
    public class BaseController
    {
    }
    public class BaseController<T>: BaseController
    {
        public BaseController()
        {
            if (_service == null)
                _service = ServiceProviderFactory.GetInstance<T>();
        }

        protected readonly T _service;
    }
}
