using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace PawnShop.Api.Filters
{
    public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute

    {
        public override void OnException(ExceptionContext context)
        {
            
            var exception = context.Exception;
            var problemDetails = new ProblemDetails
            {

               Type = "https://tools.ietf.org/html/rfc7231#section-6.6.1",
               Title = "An error occurred while processing your request.",
               Status = (int)HttpStatusCode.InternalServerError,
            };
            var errorResult = new { error = "An error occured while processing your request." };
            context.Result = new ObjectResult(errorResult);
           
            context.ExceptionHandled = true;
        }
    }
}
