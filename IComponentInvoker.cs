using System;

namespace likeselfhosting
{
    public interface IComponentInvoker
    {
        object Invoke(Type componentType, RequestContext request);
    }
}