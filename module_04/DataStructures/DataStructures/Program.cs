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
            //Action<bool> print = d => Console.WriteLine(d);
            //Func<double, double> square = d => d * d;
            //Func<double, double, double> add = (x, y) => x + y;
            //Predicate<double> isLessThanTen = d => d < 10;

            //print(isLessThanTen(square(add(3, 5))));

           
            var buffer = new CircularBuffer<double>(3);

            ProcessInput(buffer);

            Converter<double, DateTime> converter = d => new DateTime(2010, 1, 1).AddDays(d);

            var asDates = buffer.Map(converter);
            foreach (var date in asDates)
            {
                Console.WriteLine(date);
            }

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
