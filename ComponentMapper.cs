using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace likeselfhosting
{
    public class ComponentMapper : IComponentMapper
    {
        public Dictionary<string, Type> ServiceTypes { get; set; }
    }
}