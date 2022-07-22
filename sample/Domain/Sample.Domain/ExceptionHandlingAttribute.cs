
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Web.Http.Filters;

namespace Sample.Api
{
    public class SimException : Exception
    {
        public HttpStatusCode Status { get; private set; }

        public SimException(HttpStatusCode status = HttpStatusCode.InternalServerError, string msg = "undefined error") : base(msg)
        {
            Status = status;
        }
    }
    public class ExceptionHandlingAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            var t = context.Response;
            var f = context.Response.Headers;
        }
        public override async Task OnExceptionAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
        {
            var t = actionExecutedContext.Response;
            var f = actionExecutedContext.Response.Headers;
        }
    }

}
