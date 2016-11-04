using System.Collections.Generic;

namespace likeselfhosting
{
    public class RequestContext
    {
        public string Component { get; set; }
        public string Action { get; set; }
        public string BaseAddress { get; set; }

        public Dictionary<string,object> Arguments { get; set; }
    }
}