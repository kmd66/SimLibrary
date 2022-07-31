using Sample.Core.DataSource;
using Sample.Core.Service;
using Sample.Domain.Model.pbl.Student;
using Sample.Model.Dto;
using Sim.Library.BaseModel;
using Sim.Library.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.Domain
{
    public class StudentService : Service, IStudentService
    {
        public StudentService(IStudentDataQueries queries)
        {
            _queries = queries;
        }

        protected readonly IStudentDataQueries _queries;

        public async Task<Result<BaseModel>> ModifyAsync(Student model)
        {
            StudentEntity entity = StudentEntity.Create(model);
            return await entity.ModifyAsync();
        }

        public async Task<Result> RemoveAsync(Guid Id)
        {
            var model = await _queries.GetAsync(Id);
            if (!model.Success)
                return Result.Failure(message: model.Message);

            StudentEntity entity = StudentEntity.Create(model.Data);
            return await entity.RemoveAsync();
        }

        public async Task<Result<Student>> GetAsync(Guid Id)
        {
            var t = await _queries.GetAsync(Id);
            return await _queries.GetAsync(Id);
        }

        public async Task<Result<IEnumerable<Student>>> ListAsync(StudentVm model)
        {
            return await _queries.ListAsync(model);
        }
    }
}
