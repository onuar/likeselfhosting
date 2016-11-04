using System;

namespace likeselfhosting
{
    public class ComponentInvoker : IComponentInvoker
    {
        public ComponentInvoker (IInstanceInitializer instanceInitializer)
        {
          
        }
        public object Invoke(Type component, RequestContext request)
        {
            throw new NotImplementedException();
        }
    }
}