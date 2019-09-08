using System.Data.Entity;

namespace module_05
{
    public class EmployeeDb : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
