using System;

namespace module_07
{
    public class Program
    {
        static void Main()
        {
            // Unit 7.2 - Generics and Enums

            //var input = "Step1";
            //var value = input.ParseEnum<Steps>();
            //Console.WriteLine(value.GetType().Name);



            // Unit 7.3 - The Math Problem

            //var numbers = new double[] { 1, 2, 3, 4, 5, 6 };
            //var result = SampledAverage(numbers);
            //Console.WriteLine(result);



            // Unit 7.4 - Using Base Types

            //var list = new List<Item>();

            //list.Add(new Item<int>());
            //list.Add(new Item<double>());



            // Unit 7.5 - Generics and Statics

            var a = new Item<int>();
            var b = new Item<int>();
            var c = new Item<string>();

            Console.WriteLine(Item.InstanceCount);
            Console.WriteLine(Item.InstanceCount);
        }
    }


}
