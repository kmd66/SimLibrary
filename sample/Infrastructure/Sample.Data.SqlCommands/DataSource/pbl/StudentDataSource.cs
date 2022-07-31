using Sample.Model.Dto;
using Sim.Library.BaseModel;
using Sim.Library.Model;
using System;
using System.Threading.Tasks;


namespace Sample.Data.SqlCommands
{
    public class StudentDataCommands : IDataSource, Core.DataSource.IStudentDataCommands
    {
        public Task<Result<BaseModel>> ModifyAsync(Student model)
        {
            return Result<BaseModel>.SuccessfulAsync(data: new BaseModel { Id = 1, UnicId = Guid.NewGuid() });
        }

        public Task<Result> RemoveAsync(Guid Id)
        {
            return Result.SuccessfulAsync();
        }
    }
}
