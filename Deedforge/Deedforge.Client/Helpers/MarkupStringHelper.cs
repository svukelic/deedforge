using Microsoft.AspNetCore.Components;

namespace Deedforge.Client.Helpers
{
    public static class MarkupStringHelper
    {
        public static MarkupString GetMarkupString(string property)
        {
            return new MarkupString(property);
        }

        public static string ReturnStringsWithCommas(List<string> strings)
        {
            if (strings == null || strings.Count == 0)
            {
                return string.Empty;
            }

            var result = string.Empty;

            int count = strings.Count;
            int index = 0;

            foreach (string str in strings)
            {
                result += str;
                index++;
                if (index < count)
                {
                    result += ", ";
                }
            }

            return result;
        }

        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            return char.ToUpper(input[0]) + input.Substring(1);
        }
    }
}
