using System;
using System.Linq;

namespace HomeWork_9_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {33, 71, 5, 88, 42, 19, 65 };
            int resultFirst = Array.Find(arr, x => x > 40);
            int resultLast = Array.FindLast(arr, x => x > 40);
            int[] resultAll = Array.FindAll(arr, x => x > 40);

            Console.WriteLine($"First x > 40: {resultFirst}");
            Console.WriteLine();
            Console.WriteLine($"Last x > 40: {resultLast}");
            Console.WriteLine();
            Console.WriteLine("All x > 40:");

            foreach (int num in resultAll)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();


        }
    }
}
