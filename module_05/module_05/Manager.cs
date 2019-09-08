using System;

namespace module_05
{
    public class Manager : Employee
    {
        public override void DoWork()
        {
            Console.WriteLine("Create a meeting");
        }
    }
}
