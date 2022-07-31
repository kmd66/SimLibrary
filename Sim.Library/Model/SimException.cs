using Sim.Library.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Sim.Library.Model
{
    public class SimException : Exception
    {
        public HttpStatusCode Status { get; private set; }
        public List<string> Errors { get; private set; }

        public SimException(HttpStatusCode status = HttpStatusCode.InternalServerError, string msg = "undefined error") : base(msg)
        {
            Status = status;
            if (Errors == null)
                Errors = new List<string>();
            if (!string.IsNullOrEmpty(msg))
            {
                Errors.Add(msg);

                Errors = Errors.Distinct().ToList();
            }
        }

        public SimException(HttpStatusCode status = HttpStatusCode.InternalServerError, List<string> errors = null) : base("")
        {
            Errors = errors;
            Status = status;
        }

        public static SimException BadRequest(string msg = "Bad Request") => new SimException ( status: System.Net.HttpStatusCode.BadRequest, msg: msg);
        public static SimException BadRequest(List<string> errors = null) => new SimException(status: System.Net.HttpStatusCode.BadRequest, errors: errors);

        public  Result Failure()
            => new Result { 
                Success = false, 
                Code = (int)Status, 
                Errors = Errors };
    }
}
