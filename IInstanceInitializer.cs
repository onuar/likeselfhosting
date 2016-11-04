using System;

namespace likeselfhosting
{
    public interface IInstanceInitializer
    {
        object GetInstance(Type componentType);
    }
}