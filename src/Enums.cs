using System;

namespace JotunShard.Globalization
{
    public static class Enums
    {
        public static string GetStringValue(this Enum value)
            => ((StringEnumValuAttribute)Attribute.GetCustomAttribute(value.GetType(), typeof(StringEnumValuAttribute)))?.Value;
    }
}