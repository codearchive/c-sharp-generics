using System;

namespace DataStructures
{
    class Program
    {
        //static void ConsoleWrite(double data)
        //{
        //    Console.WriteLine(data);
        //}

        static void Main()
        {
            //Action<double> print = ConsoleWrite;

            // Using anonymous method instead
            //Action<double> print = delegate(double data)
            //{
            //    Console.WriteLine(data);
            //};

            // Using lambda expression
            //Action<double> print = d => Console.WriteLine(d);

            var buffer = new CircularBuffer<double>(3);

            ProcessInput(buffer);

            //Printer<double> consoleOut = new Printer<double>(ConsoleWrite);
            // 
            // We can use ConsoleWrite function directly.
            // Behind the scene compiler will instantiate delegate.
             
            //Inline lambda expression
            buffer.Dump(d => Console.WriteLine(d));

            ProcessBuffer(buffer);
        }

        private static void ProcessBuffer(IBuffer<double> buffer)
        {
            var sum = 0.0;
            Console.WriteLine("Buffer: ");
            while (!buffer.IsEmpty)
            {
                sum += buffer.Read();
            }
            Console.WriteLine(sum);
        }

        private static void ProcessInput(IBuffer<double> buffer)
        {
            while (true)
            {
                var value = 0.0;
                var input = Console.ReadLine();

                if (double.TryParse(input, out value))
                {
                    buffer.Write(value);
                    continue;
                }
                break;
            }
        }
    }
}
