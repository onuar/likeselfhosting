using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

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
            IComponentMapper mapper = _provider.GetService<IComponentMapper>();
            var pathParser = new PathParser();
            var request = pathParser.Parse(context.Request);

            var componentType = mapper.GetComponent(request.Component);

            var componentInstance = _provider.GetService(componentType);

            var result = _invoker.Invoke(componentType, request);

            var serialized = JsonConvert.SerializeObject(result);
            var bytes = Encoding.UTF8.GetBytes(serialized);
            context.Response.ContentType = "application/json";

            await context.Response.Body.WriteAsync(bytes, 0, bytes.Length);
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