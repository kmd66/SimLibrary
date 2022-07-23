using Sample.Model.Dto;
using Sim.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Sample.Data.SqlCommands
{
    public class StudentDataCommands : Sim.Core.Model.IDataSource, Core.DataSource.IStudentDataCommands
    {
        public Task<Result<BaseModel>> ModifyAsync(Student model)
        {
            return Result<BaseModel>.SuccessfulAsync(data: new BaseModel { Id = 1, UnicId = Guid.NewGuid() });
        }

        public Task<Result> DeleteAsync(Guid Id)
        {
            return Result.SuccessfulAsync();
        }
    }
}
