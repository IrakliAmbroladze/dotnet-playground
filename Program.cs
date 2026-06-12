using System;
using System.Linq;

namespace HomeWork_9_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 25, 3, 48, 7, 99, 56, 2 };

            var filteredResult = numbers.Where(n => n > 20 && n <60);

            foreach (var num in filteredResult)
            {
                Console.WriteLine(num);
            }
        }
    }
}
