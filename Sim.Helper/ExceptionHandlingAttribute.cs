﻿//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Web.Http.Filters;

//namespace Sim.Helper
//{
//    //public class ExceptionHandlingAttribute : ExceptionFilterAttribute
//    //{
//    //    public override void OnException(HttpActionExecutedContext context)
//    //    {
//    //        if (context.Exception is BusinessException)
//    //        {
//    //            throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError)
//    //            {
//    //                Content = new StringContent(context.Exception.Message),
//    //                ReasonPhrase = "Exception"
//    //            });

//    //        }

//    //        //Log Critical errors
//    //        Debug.WriteLine(context.Exception);

//    //        throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError)
//    //        {
//    //            Content = new StringContent("An error occurred, please try again or contact the administrator."),
//    //            ReasonPhrase = "Critical Exception"
//    //        });
//    //    }
//    //}

//}
