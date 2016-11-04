using System;

namespace likeselfhosting
{
    public interface IComponentInvoker
    {
        object Invoke(Type component, RequestContext request);
    }
}