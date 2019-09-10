using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_07
{
    public static class StringExtensions
    {
        public static TEnum ParseEnum<TEnum>(this string value) where TEnum: System.Enum
        {
            return (TEnum)Enum.Parse(typeof(TEnum), value);
        }
    }

    public enum Steps
    {
        Step1,
        Step2,
        Step3
    }

    class Program
    {
        static void Main()
        {
            var input = "Step1";
            var value = input.ParseEnum<Steps>();
            Console.WriteLine(value.GetType().Name);
        }
    }
}
