using System;

namespace module_07
{
    public enum Steps
    {
        Step1,
        Step2,
        Step3
    }

    public static class StringExtensions
    {
        public static TEnum ParseEnum<TEnum>(this string value) where TEnum : System.Enum
        {
            return (TEnum)Enum.Parse(typeof(TEnum), value);
        }
    }
}
