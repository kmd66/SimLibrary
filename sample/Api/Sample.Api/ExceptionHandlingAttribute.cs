
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Web.Http.Filters;

namespace Sample.Api
{
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
