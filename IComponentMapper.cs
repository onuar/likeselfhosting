using System;

namespace likeselfhosting
{
    public interface IComponentMapper
    {
        Type GetComponent(string alias);

        void AddComponent(string alias,Type type);
    }
}