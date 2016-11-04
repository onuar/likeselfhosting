using System;
using System.Collections.Generic;

namespace likeselfhosting
{
    public class ComponentMapper : IComponentMapper
    {
        private readonly Dictionary<string, Type> _serviceTypes;

        public ComponentMapper ()
        {
          _serviceTypes = new Dictionary<string,Type>();
        }

        public void AddComponent(string alias, Type type)
        {
            _serviceTypes.Add(alias,type);
        }

        public Type GetComponent(string alias)
        {
            Type type;
            _serviceTypes.TryGetValue(alias,out type);
            return type;
        }
    }
}