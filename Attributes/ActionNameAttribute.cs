using System;

namespace likeselfhosting.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ActionNameAttribute : Attribute
    {
        public string Name { get; private set; }

        public ActionNameAttribute(string name)
        {
            Name = name;
        }
    }
}