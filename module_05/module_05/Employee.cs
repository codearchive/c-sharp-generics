using System;

namespace module_05
{
    public class Employee : Person, IEntity
    {
        public int Id { get; set; }

        public virtual void DoWork()
        {
            Console.WriteLine("Doing real work");
        }

        public bool IsValid()
        {
            return true;
        }
    }
}
