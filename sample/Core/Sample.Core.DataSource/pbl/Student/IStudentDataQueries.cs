using Sim.Library.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.Core.DataSource
{
    public interface IStudentDataQueries : IDataSource
    {
        Task<Result<Model.Dto.Student>> GetAsync(Guid Id);

        Task<Result<IEnumerable<Model.Dto.Student>>> ListAsync(Model.Dto.StudentVm model);

    }
}
