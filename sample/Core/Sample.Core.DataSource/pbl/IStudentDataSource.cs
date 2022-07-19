using Sim.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Core.DataSource
{
    public interface IStudentDataSource : IDataSource
    {
        Task<Result<Model.Dto.Student>> GetAsync(Guid Id);

        Task<Result<IEnumerable<Model.Dto.Student>>> ListAsync(Model.Dto.StudentVm model);

        Task<Result<Guid>> CreateAsync( Model.Dto.Student model);

        Task<Result<Guid>> UpdateAsync(Model.Dto.Student model);

        Task<Result> DeleteAsync(Guid Id);


    }
}
