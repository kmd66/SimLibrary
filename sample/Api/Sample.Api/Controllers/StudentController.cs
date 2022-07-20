using Microsoft.AspNetCore.Mvc;
using Sample.Model.Dto;
using Sim.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController
    {
        public StudentController(Core.Service.IStudentService service)
        {
            _service = service;
        }

        protected readonly Core.Service.IStudentService _service;

        [HttpPost, Route("Get")]
        public Task<Result<Student>> Get(Guid Id)
            => _service.GetAsync(Id);

        [HttpPost, Route("List")]
        public Task<Result<IEnumerable<Student>>> List(StudentVm model)
            => _service.ListAsync(model);

        [HttpPost, Route("Create")]
        public Task<Result<Guid>> Create(Student model)
            => _service.CreateAsync(model);

        [HttpPost, Route("Delete")]
        public Task<Result> Delete(Guid Id)
            => _service.DeleteAsync(Id);

        [HttpPost, Route("Update")]
        public Task<Result<Guid>> Update(Student model)
            => _service.UpdateAsync(model);
    }
}
