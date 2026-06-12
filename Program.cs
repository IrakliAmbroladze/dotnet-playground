using System;
using System.Linq;

namespace HomeWork_9_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr= { 5, 3, 8, 3, 9, 5, 1, 8, 2 };
            
            int[] result = arr.Distinct().OrderBy(i=>i).ToArray();

            foreach(var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
