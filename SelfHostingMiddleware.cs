using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace likeselfhosting
{
    public class SelfHostingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IServiceProvider _provider;
        private readonly IComponentInvoker _invoker;

        public SelfHostingMiddleware(RequestDelegate next, IServiceProvider provider, IComponentInvoker invoker)
        {
            _next = next;
            _provider = provider;
            _invoker = invoker;
        }

        public async Task Invoke(HttpContext context)
        {
            // await context.Response.WriteAsync(context.Request.Path);

            IComponentMapper mapper = _provider.GetService<IComponentMapper>();



            var pathParser = new PathParser();
            var request = pathParser.Parse(context.Request);

            var componentType = mapper.GetComponent(request.Component);

            var componentInstance = _provider.GetService(componentType);

            await context.Response.WriteAsync(componentInstance.GetType().ToString());

            // await context.Response.WriteAsync(request.Action);

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