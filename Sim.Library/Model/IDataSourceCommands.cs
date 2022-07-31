using System;
using System.Threading.Tasks;

namespace Sim.Library.Model
{
    public interface IDataSourceCommands<Model> : IDataSource
    {
        Task<Result<Sim.Library.BaseModel.BaseModel>> ModifyAsync(Model model);

        Task<Result> RemoveAsync(Guid Id);
    }
}
