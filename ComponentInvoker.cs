using System;

namespace likeselfhosting
{
    public class ComponentInvoker : IComponentInvoker
    {
        private readonly IInstanceInitializer _instanceInitializer;
        public ComponentInvoker(IInstanceInitializer instanceInitializer)
        {
            _instanceInitializer = instanceInitializer;
        }
        public object Invoke(Type componentType, RequestContext request)
        {
            object instance = _instanceInitializer.GetInstance(componentType);

            return null;
        }
    }
}