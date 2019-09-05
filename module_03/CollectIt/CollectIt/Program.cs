using System;

namespace CollectIt
{
    class Program
    {
        static void Main(string[] args)
        {
            DepartmentCollection departments = new DepartmentCollection();

            departments.Add("Sales", new Employee { Name = "Joy" })
                       .Add("Sales", new Employee { Name = "Alex" })
                       .Add("Sales", new Employee { Name = "Alex" });
            
            departments.Add("Engineering", new Employee { Name = "Scoot" })
                       .Add("Engineering", new Employee { Name = "Alex" })
                       .Add("Engineering", new Employee { Name = "Dani" });

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
