using System;

namespace JotunShard.Globalization
{
    [AttributeUsage(AttributeTargets.Field)]
    public class StringEnumValuAttribute : Attribute
    {
        public string Value { get; }

        public StringEnumValuAttribute(string value)
        {
            Value = value;
        }
    }
}