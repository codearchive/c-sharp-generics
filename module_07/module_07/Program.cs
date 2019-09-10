using System;

namespace module_07
{
    public class Program
    {
        static void Main()
        {
            //var input = "Step1";
            //var value = input.ParseEnum<Steps>();
            //Console.WriteLine(value.GetType().Name);

            var numbers = new double[] {1, 2, 3, 4, 5, 6};
            var result = SampledAverage(numbers);
            Console.WriteLine(result);
        }

        private static double SampledAverage(double[] numbers)
        {
            var count = 0;
            var sum = 0.0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                count += 1;
            }

            return sum / count;
        }
    }
}
