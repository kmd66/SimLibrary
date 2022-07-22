using Sim.Core.Connector;
using Sim.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Domain.Model
{
    public class BaseEntity : Sim.Core.Model.BaseEntity
    {
        public BaseEntity()
        {
            _mapServiceNew();
        }
        protected static T1 New<T1, T2>(T2 model)
        {
            _mapServiceNew(); 
            return _mapService.Map<T1, T2>(model);
        }
        static void _mapServiceNew()
        {
            if (_mapService == null)
                _mapService = ServiceProviderFactory.GetInstance<Sim.Core.Connector.IMapService>();
        }

        protected static IMapService _mapService;
    }
}
