using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Threading.Tasks;
using Ze_Delivery_Domain.Entities;

namespace Ze_Delivery_API.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }
        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";

            var code = HttpStatusCode.InternalServerError;
            if (exception is ValidationException) code = HttpStatusCode.UnprocessableEntity;

            context.Response.StatusCode = (int)code;
            return context.Response.WriteAsync(
                new ErrorDetails()
                {
                    statusCode = (int)code,
                    message = exception.Message
                }.ToString()
            );
        }
    }
}
