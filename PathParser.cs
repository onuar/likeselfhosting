using Microsoft.AspNetCore.Http;

namespace likeselfhosting
{
    internal class PathParser
    {
        internal RequestContext Parse(HttpRequest context)
        {
            var request = new RequestContext();
            var path = context.Path;
            var splittedPath = path.Value.Split('/');
            if (splittedPath.Length != 3)
            {
                throw new InvalidUrlException(path);
            }
            
            request.BaseAddress =splittedPath[0]; 
            request.Component = splittedPath[1];
            request.Action = splittedPath[2];
            // todo(onuar): parse request body for request.Arguments
            return request;
        }
    }
}