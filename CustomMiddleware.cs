using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomMiddleware
{
    


    public class CustomMiddleware1
    {
    
        private readonly RequestDelegate _next;

        public CustomMiddleware1(RequestDelegate next)
        {
        _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
       
        await Task.Run(async () =>
        {   await context.Response.WriteAsync($"<p>URL: {context.Request.Path}</p>");
            await context.Response.WriteAsync($"<p>Scheme: {context.Request.Scheme}</p>");
            await context.Response.WriteAsync($"<p>Host: {context.Request.Host.ToString()}</p>");
            await context.Response.WriteAsync($"<p>QueryString: {context.Request.QueryString.ToString()}</p>");
            await context.Response.WriteAsync($"<p>Body: {context.Request.Body.ToString()}</p>");
        });
        }
    }
}
    
