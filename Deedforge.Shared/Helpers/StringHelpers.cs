﻿namespace Deedforge.Shared.Helpers
{
    public static class StringHelpers
    {
        public static string GetDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = field?.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false)
                .FirstOrDefault() as System.ComponentModel.DescriptionAttribute;
            return attribute?.Description ?? value.ToString();
        }
    }
}
