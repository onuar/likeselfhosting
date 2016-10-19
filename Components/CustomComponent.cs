using Businesses.Foundation;

namespace Businesses
{
    public class CustomComponent : ICustomComponent
    {
        string ICustomComponent.Do()
        {
            return "Hello api";
        }
    }
}