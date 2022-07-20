using Sim.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Core.DataSource
{
    public interface IStudentDataCommands : IDataSource
    {
        Task<Result<Guid>> CreateAsync( Model.Dto.Student model);

        Task<Result> UpdateAsync(Model.Dto.Student model);

        Task<Result> DeleteAsync(Guid Id);


    }
}
