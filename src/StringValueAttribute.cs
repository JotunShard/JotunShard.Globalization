using System;

namespace JotunShard.Globalization
{
    [AttributeUsage(AttributeTargets.Field)]
    public class StringValuAttribute : Attribute
    {
        public string Value { get; }

        public StringValuAttribute(string value)
        {
            Value = value;
        }
    }
}