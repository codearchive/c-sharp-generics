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
            var buffer = new CircularBuffer<double>(3);

            buffer.ItemDiscarded += ItemDiscarded;

            ProcessInput(buffer);

            buffer.Dump(d => Console.WriteLine(d));

            ProcessBuffer(buffer);
        }

        private static void ItemDiscarded(object sender, ItemDiscardedEventArgs<double> e)
        {
            Console.WriteLine("Buffer is full. Discarding {0} New item is {1}", e.ItemDiscarded, e.NewItem);
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
