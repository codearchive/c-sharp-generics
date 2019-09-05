using System;
using System.Collections.Generic;

namespace CollectIt
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedSet<Employee>> departments = new SortedDictionary<string, SortedSet<Employee>>();

            departments.Add("Sales", new SortedSet<Employee>(new EmployeeComparer()));
            departments["Sales"].Add(new Employee { Name = "Joy" });
            departments["Sales"].Add(new Employee { Name = "Alex" });
            departments["Sales"].Add(new Employee { Name = "Alex" });

            departments.Add("Engineering", new SortedSet<Employee>(new EmployeeComparer()));
            departments["Engineering"].Add(new Employee { Name = "Scoot" });
            departments["Engineering"].Add(new Employee { Name = "Alex" });
            departments["Engineering"].Add(new Employee { Name = "Dani" });

            foreach (var department in departments)
            {
                Console.WriteLine(department.Key);
                foreach (var employee in department.Value)
                {
                    Console.WriteLine("\t" + employee.Name);
                }
            }
        }
    }
}
