using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sim.Library.Model
{
    public interface IService
    {

    }
    public interface IService<Model, ModelVm> : IService
    {
        Task<Result<Model>> GetAsync(Guid Id);

        Task<Result<IEnumerable<Model>>> ListAsync(ModelVm model);

        Task<Result<Sim.Library.BaseModel.BaseModel>> ModifyAsync(Model model);

        Task<Result> RemoveAsync(Guid Id);
    }
}
