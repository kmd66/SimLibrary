using Sample.Model.Dto;
using Sim.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Data.SqlQueries
{
    public class StudentDataSource : Sim.Core.Model.IDataSource, Core.DataSource.IStudentDataSource
    {
        public Task<Result<Guid>> CreateAsync(Student model)
        {
            throw new NotImplementedException();
        }

        public Task<Result> DeleteAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<Student>> GetAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<IEnumerable<Student>>> ListAsync(StudentVm model)
        {
            throw new NotImplementedException();
        }

        public Task<Result<Guid>> UpdateAsync(Student model)
        {
            throw new NotImplementedException();
        }
    }
}
