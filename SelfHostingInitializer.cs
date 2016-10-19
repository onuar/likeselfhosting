using Microsoft.Extensions.DependencyInjection;

namespace likeselfhosting
{
    public class SelfHostingInitializer : IServiceConfigurator, ICompositeConfiguratorRunnable,ISelfHostingInitializer
    {
        private readonly IServiceCollection _services;
        public SelfHostingInitializer(IServiceCollection services)
        {
            _services = services;
        }

        public ICompositeConfiguratorRunnable Init()
        {
            return this;
        }

        ICompositeConfiguratorRunnable IServiceConfigurator.AddComponent<TBase, TComponent>()
        {
            return this;
        }

        ICompositeConfiguratorRunnable IServiceConfigurator.AddComponent<TBase, TComponent>(string name)
        {
             return this;
        }

        ISelfHostingInitializer ICompositeConfiguratorRunnable.Run()
        {
            return this;
        }
    }
}