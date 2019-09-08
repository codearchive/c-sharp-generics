using System;
using System.Data.Entity;
using System.Linq;

namespace module_05
{
    class Program
    {
        static void Main()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<EmployeeDb>());

            using (IRepository<Employee> employeeRepository = new Sqlrepository<Employee>(new EmployeeDb()))
            {
                AddEmployee(employeeRepository);
                CountEmployee(employeeRepository);
                QueryEmployees(employeeRepository);
                DumpPeople(employeeRepository);
            }
        }

        private static void DumpPeople(IReadOnlyRepository<Person> employeeRepository)
        {
            var employees = employeeRepository.FindAll();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name);
            }
        }

        private static void QueryEmployees(IRepository<Employee> employeeRepository)
        {
            var emloyee = employeeRepository.FindById(1);
            Console.WriteLine(emloyee.Name);
        }

        private static void CountEmployee(IRepository<Employee> employeeRepository)
        {
            Console.WriteLine(employeeRepository.FindAll().Count());
        }

        private static void AddEmployee(IRepository<Employee> employeeRepository)
        {
            employeeRepository.Add(new Employee { Name = "Scott" });
            employeeRepository.Add(new Employee { Name = "Chris" });
            employeeRepository.Commit();
        }
    }
}
