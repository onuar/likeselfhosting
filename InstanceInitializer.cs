using System;

namespace likeselfhosting
{
    public class InstanceInitializer : IInstanceInitializer
    {
        private readonly IServiceProvider _provider;
        public InstanceInitializer (IServiceProvider provider)
        {
          _provider = provider;
        }
        public object GetInstance(Type componentType)
        {
            var instance = _provider.GetService(componentType);
            return instance;
        }
    }
}