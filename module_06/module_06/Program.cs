using System;
using System.Collections.Generic;

namespace module_06
{
    public class Program
    {
        public static void Main()
        {
            var employeeList = CreateCollection(typeof(List<>), typeof(Employee));
            Console.Write(employeeList.GetType().Name);
            var genericArguments = employeeList.GetType().GetGenericArguments();
            foreach (var genericArgument in genericArguments)
            {
                Console.WriteLine("[{0}]", genericArgument.Name);
            }

            Console.WriteLine();
        }

        private static object CreateCollection(Type collectionType, Type itemType)
        {
            var closedType = collectionType.MakeGenericType(itemType);
            return Activator.CreateInstance(closedType);
        }
    }
}
