using System;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http.Filters;
using Chart.API.Models;

namespace Chart.API.Filters
{
    public class GenericExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public GenericExceptionFilterAttribute()
        { }

        public override void OnException(HttpActionExecutedContext context)
        {
            var response = new ActionResponse();
            response.Success = false;

            HttpStatusCode code;

            if (context.Exception is NotImplementedException)
                code = HttpStatusCode.NotImplemented;
            else
                code = HttpStatusCode.InternalServerError;

            response.Messages.Add(new Response() { StatusCode = code, Message = context.Exception.Message });

            context.Response = context.Request.CreateResponse(code, response);
        }
    }
}