using System;
using System.Collections.Generic;

namespace CollectIt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Unit 2.2 - LIST<T>

            //var numbers = new List<int>(10);
            //var capacity = -1;

            //while (true)
            //{
            //    if (numbers.Capacity != capacity)
            //    {
            //        capacity = numbers.Capacity;
            //        Console.WriteLine(capacity);
            //    }

            //    numbers.Add(1);
            //}



            // Unit 2.3 - QUEUE<T>

            Queue<Employee> line = new Queue<Employee>();
            line.Enqueue(new Employee { Name  = "Alex" });
            line.Enqueue(new Employee { Name  = "Paul" });
            line.Enqueue(new Employee { Name  = "Chris" });

            while (line.Count > 0)
            {
                var employee = line.Dequeue();
                Console.WriteLine(employee.Name);
            }
            
        }
    }
}
