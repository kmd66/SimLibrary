using Sample.Model.Dto;
using Sim.Library.BaseModel;
using Sim.Library.Model;
using System;
using System.Threading.Tasks;

namespace Sample.Core.DataSource
{
    public interface IStudentDataCommands : IDataSource
    {
        Task<Result<BaseModel>> ModifyAsync(Student model);

        Task<Result> RemoveAsync(Guid Id);


    }
}
