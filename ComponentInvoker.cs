using System;
using System.Reflection;

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
            var method = componentType.GetMethod(request.Action);
            ParameterInfo[] parameterInfos = method.GetParameters();
            //pass method parameters
            var result = method.Invoke(instance, null);
            return result;
        }
    }
}