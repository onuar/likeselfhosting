using System;
using System.Collections.Generic;

namespace likeselfhosting
{
    public interface IComponentMapper
    {
        Dictionary<string, Type> ServiceTypes { get; set; }
    }
}