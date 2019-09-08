using System;

namespace module_05
{
    public class Employee : Person
    {
        public int Id { get; set; }

        public virtual void DoWork()
        {
            Console.WriteLine("Doing real work");
        }
    }
}
