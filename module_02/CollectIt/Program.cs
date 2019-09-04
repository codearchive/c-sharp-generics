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

            //Queue<Employee> line = new Queue<Employee>();
            //line.Enqueue(new Employee { Name = "Alex" });
            //line.Enqueue(new Employee { Name = "Paul" });
            //line.Enqueue(new Employee { Name = "Chris" });

            //Console.WriteLine("--QUEUE<T>--");
            //var countQueue = line.Count;
            //for (int i = 0; i < countQueue; i++)
            //{
            //    var employee = line.Dequeue();
            //    Console.WriteLine($"^ - {i} - {employee.Name}");
            //}



            // Unit 2.4 - STACK

            //Stack<Employee> stack = new Stack<Employee>();
            //stack.Push(new Employee { Name = "Alex" });
            //stack.Push(new Employee { Name = "Paul" });
            //stack.Push(new Employee { Name = "Chris" });

            //Console.WriteLine("\n--STACK<T>--");
            //var countStack = stack.Count;
            //for (int i = 0; i < countStack; i++)
            //{
            //    var employee = stack.Pop();
            //    Console.WriteLine($"^ - {i} - {employee.Name}");
            //}



            // Unit 2.5 - SET<T>

            //HashSet<Employee> set = new HashSet<Employee>();
            //set.Add(new Employee { Name = "Alex" }); // It is two different
            //set.Add(new Employee { Name = "Alex" }); // objects

            //var employee = new Employee { Name = "Paul" };
            //set.Add(employee);
            //set.Add(employee);
            //set.Add(new Employee { Name = "Chris" });
            
            //foreach (var item in set)
            //{
            //    Console.WriteLine(item.Name);
            //}



            // Unit 2.6 - LINK<T>

            //LinkedList<int> list = new LinkedList<int>();
            //list.AddFirst(2);
            //list.AddFirst(3);

            //var first = list.First;
            //list.AddAfter(first, 5);
            //list.AddBefore(first, 10);

            //var node = list.First;
            //while (node != null)
            //{
            //    Console.WriteLine(node.Value);
            //    node = node.Next;
            //}


            // Unit 2.7 - DICTIONARY<T>

            Dictionary<string, Employee> employeesByName = new Dictionary<string, Employee>();

            employeesByName.Add( "Scott",  new Employee { Name = "Scott" });
            employeesByName.Add( "Alex",  new Employee { Name = "Alex" });
            employeesByName.Add( "Joy",  new Employee { Name = "Joy" });

            foreach (var item in employeesByName)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value.Name);
            }

            Dictionary<string, List<Employee>> employeesList = new Dictionary<string, List<Employee>>();

            employeesList.Add("Software Department", new List<Employee> { new Employee { Name = "Scott"} });

            employeesList["Software Department"].Add(new Employee { Name = "Tom"});

            foreach (var item in employeesList)
            {
                foreach (var person in item.Value)
                {
                    Console.WriteLine(person.Name);
                }
            }
        }
    }
}
