using Microsoft.Extensions.DependencyInjection;

namespace likeselfhosting
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddComponentTransient<TBase,TComponent>(this IServiceCollection service)
            where TBase : class
            where TComponent : class, TBase
        {
            service.AddTransient<TBase,TComponent>();
            return service;
        }
    }
}