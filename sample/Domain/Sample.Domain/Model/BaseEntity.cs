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
                _mapService = ServiceProviderFactory.GetInstance<Sim.Core.Connector.IMapService>(); 
            }

            protected readonly IMapService _mapService;
        }
}
