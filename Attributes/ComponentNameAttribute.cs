using System;

namespace likeselfhosting.Attributes
{
    [AttributeUsage(AttributeTargets.Interface)]
    public class ComponentNameAttribute : Attribute
    {
        public string Name { get; private set; }

        public ComponentNameAttribute(string name)
        {
            Name = name;
        }
    }
}