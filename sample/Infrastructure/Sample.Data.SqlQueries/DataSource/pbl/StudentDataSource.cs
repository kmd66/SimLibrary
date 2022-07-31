using Sample.Model.Dto;
using Sim.Library.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.Data.SqlQueries
{
    public class StudentDataQueries : IDataSource, Core.DataSource.IStudentDataQueries
    {
        public Task<Result<Student>> GetAsync(Guid Id)
        {
            return Result<Student>.SuccessfulAsync(data: new Student());
        }

        public Task<Result<IEnumerable<Student>>> ListAsync(StudentVm model)
        {
            return Result<IEnumerable<Student>>.SuccessfulAsync(data: new List<Student> { new Student() });
        }
    }
}
