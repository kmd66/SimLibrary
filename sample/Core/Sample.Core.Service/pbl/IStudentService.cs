using Sim.Library.BaseModel;
using Sim.Library.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.Core.Service
{
    public interface IStudentService  : IService<Model.Dto.Student, Model.Dto.StudentVm>
    {
    }
}
