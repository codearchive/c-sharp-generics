using System;
using System.Collections.Generic;

namespace CollectIt
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>(10);
            var capacity = -1;

            while (true)
            {
                if (numbers.Capacity != capacity)
                {
                    capacity = numbers.Capacity;
                    Console.WriteLine(capacity);
                }

                numbers.Add(1);
            }

        }
    }
}
