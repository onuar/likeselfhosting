using System;
using Microsoft.Extensions.DependencyInjection;

namespace likeselfhosting
{
    public class SelfHostingInitializer : IServiceConfigurator, ICompositeConfiguratorRunnable, ISelfHostingInitializer
    {
        private readonly IServiceCollection _services;

        private IComponentMapper _mapper;
        public SelfHostingInitializer(IServiceCollection services)
        {
            _services = services;
        }

        public ICompositeConfiguratorRunnable Init()
        {
            _mapper = new ComponentMapper();
            _services.AddSingleton<IComponentMapper>(_mapper);
            _services.AddTransient<IInstanceInitializer, InstanceInitializer>();
            _services.AddTransient<IComponentInvoker, ComponentInvoker>();
            return this;
        }

        ICompositeConfiguratorRunnable IServiceConfigurator.AddComponent<TBase, TComponent>()
        {
            _services.AddTransient<TBase, TComponent>();
            _mapper.AddComponent("compo", typeof(TBase));
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