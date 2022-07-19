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

        [HttpGet]
        public async Task<Result<Student>> Get()
        {
            //new Sample.Domain.StudentService().GetAsync(Guid.NewGuid());
            //return Result<Student>.Successful();
            return await _service.GetAsync(Guid.NewGuid());
        }
    }
}
