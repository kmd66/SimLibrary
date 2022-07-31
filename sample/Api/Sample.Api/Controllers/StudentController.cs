using Microsoft.AspNetCore.Mvc;
using Sample.Model.Dto;
using Sim.Library.BaseModel;
using Sim.Library.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : BaseController<Core.Service.IStudentService>
    {
        public StudentController() : base()
        {
        }

        [HttpPost, Route("Get")]
        public Task<Result<Student>> Get(Guid Id)
            => _service.GetAsync(Id);

        [HttpPost, Route("List")]
        public Task<Result<IEnumerable<Student>>> List(StudentVm model)
            => _service.ListAsync(model);

        [HttpPost, Route("Modify")]
        public Task<Result<BaseModel>> Modify(Student model)
            => _service.ModifyAsync(model);

        [HttpPost, Route("Remove")]
        public Task<Result> Remove(Guid Id)
            => _service.RemoveAsync(Id);
    }
}
