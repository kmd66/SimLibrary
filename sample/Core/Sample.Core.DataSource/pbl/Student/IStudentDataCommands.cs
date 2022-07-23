using Sample.Model.Dto;
using Sim.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Core.DataSource
{
    public interface IStudentDataCommands : IDataSource
    {
        Task<Result<BaseModel>> ModifyAsync(Student model);

        Task<Result> DeleteAsync(Guid Id);


    }
}
