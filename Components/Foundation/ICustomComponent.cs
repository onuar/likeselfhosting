using likeselfhosting.Attributes;

namespace Businesses.Foundation
{
    [ComponentName("compo")]
    public interface ICustomComponent
    {
        [ActionName("do")]
        string Do();
    }
}