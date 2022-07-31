using Sim.Library.BaseModel;
using Sim.Library.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.Core.Service
{
    public interface IStudentService  : IService
    {
        Task<Result<Model.Dto.Student>> GetAsync(Guid Id);

        Task<Result<IEnumerable<Model.Dto.Student>>> ListAsync(Model.Dto.StudentVm model);

        Task<Result<BaseModel>> ModifyAsync(Model.Dto.Student model);

        Task<Result> RemoveAsync(Guid Id);


    }
}
