using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sim.Library.Model
{
    public interface IDataSourceQueries<Model, ModelVm> : IDataSource
    {
        Task<Result<Model>> GetAsync(Guid Id);

        Task<Result<IEnumerable<Model>>> ListAsync(ModelVm model);
    }
}
