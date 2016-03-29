using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace Test1
{
    // You may need to install the Microsoft.AspNet.Http.Abstractions package into your project
    public class GlenMiddleware
    {
        private readonly RequestDelegate _next;

        public GlenMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            var headerVal = httpContext.Response.Headers.GetCommaSeparatedValues("Server");
            if (headerVal.Length > 0)
            {
                httpContext.Response.Headers.Remove("Server");
                httpContext.Response.Headers.Add("Server", "Glen");
            }
            
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class GlenMiddlewareExtensions
    {
        public static IApplicationBuilder UseGlenMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<GlenMiddleware>();
        }
    }
}
