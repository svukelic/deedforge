using Microsoft.AspNetCore.Components;

namespace Deedforge.Client.Helpers
{
    public static class MarkupStringHelper
    {
        public static MarkupString GetMarkupString(string property)
        {
            return new MarkupString(property);
        }
    }
}
