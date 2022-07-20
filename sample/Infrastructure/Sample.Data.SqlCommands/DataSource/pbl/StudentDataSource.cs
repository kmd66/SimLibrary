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
        public Task<Result<Guid>> CreateAsync(Student model)
        {
            return Result<Guid>.SuccessfulAsync(data: Guid.NewGuid());
        }

        public Task<Result> DeleteAsync(Guid Id)
        {
            return Result.SuccessfulAsync();
        }

        public Task<Result> UpdateAsync(Student model)
        {
            return Result.SuccessfulAsync();
        }
    }
}
