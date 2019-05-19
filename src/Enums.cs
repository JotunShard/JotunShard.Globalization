using System;

namespace JotunShard.Globalization
{
    public static class Enums
    {
        public static string GetStringValue(this Enum value)
            => ((StringValuAttribute)Attribute.GetCustomAttribute(value.GetType(), typeof(StringValuAttribute)))?.Value;
    }
}