using AutoMapper;
using Sim.Core.Connector;

namespace Sim.Helper
{
    public class AutoMapperPg: IMapService
    {
        public AutoMapperPg() { }
        public T1 Map<T1, T2>(T2 t2)
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<T2, T1>();
            });
            // only during development, validate your mappings; remove it before release
            //mapperConfiguration.AssertConfigurationIsValid();

            var mapper = mapperConfiguration.CreateMapper();

            var model = mapper.Map<T1>(t2);

            return model;
        }
    }

}
