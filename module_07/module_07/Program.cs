using System.Collections.Generic;

namespace module_07
{
    public class Program
    {
        static void Main()
        {
            //var input = "Step1";
            //var value = input.ParseEnum<Steps>();
            //Console.WriteLine(value.GetType().Name);

            //var numbers = new double[] { 1, 2, 3, 4, 5, 6 };
            //var result = SampledAverage(numbers);
            //Console.WriteLine(result);

            var list = new List<Item>();

            list.Add(new Item<int>());
        }
    }

    public class Item<T> : Item
    {

    }

    public class Item
    {

    }
}
