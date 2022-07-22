using Sample.Core.DataSource;
using Sample.Core.Service;
using Sample.Domain.Model.pbl.Student;
using Sample.Model.Dto;
using Sim.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Domain
{
    public class StudentService : Service, IStudentService
    {
        public StudentService(IStudentDataCommands commands,
            IStudentDataQueries queries)
        {
            _commands = commands;
            _queries = queries;
        }

        protected readonly IStudentDataCommands _commands;
        protected readonly IStudentDataQueries _queries;

        public async Task<Result<Guid>> CreateAsync(Student model)
        {
            StudentEntity s = StudentEntity.Create(model);
            return await  _commands.CreateAsync(model);
        }

        public async Task<Result> DeleteAsync(Guid Id)
        {
            return await _commands.DeleteAsync(Id);
        }

        public async Task<Result<Guid>> UpdateAsync(Student model)
        {
            return Result<Guid>.Successful(data: Guid.NewGuid());
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
