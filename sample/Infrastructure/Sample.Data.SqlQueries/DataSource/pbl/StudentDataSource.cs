using Sample.Model.Dto;
using Sim.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Data.SqlQueries
{
    public class StudentDataQueries : Sim.Core.Model.IDataSource, Core.DataSource.IStudentDataQueries
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
