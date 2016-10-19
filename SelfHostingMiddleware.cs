using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace likeselfhosting
{
    public class SelfHostingMiddleware
    {
        private readonly RequestDelegate _next;

        public SelfHostingMiddleware (RequestDelegate next)
        {
           _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            // await context.Response.WriteAsync(context.Request.Path);

            var pathParser = new PathParser();
            var request = pathParser.Parse(context.Request);
            await context.Response.WriteAsync(request.Action);

            // await _next.Invoke(context);
        }
    }

    public static class SelfHostingMiddlewareExtension
    {
        public static IApplicationBuilder AddSelfHosting(this IApplicationBuilder app)
        {
            app.UseMiddleware<SelfHostingMiddleware>();
            return app;
        }
    }
}