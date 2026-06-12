using System;
using System.Linq;

namespace HomeWork_9_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            Console.WriteLine($"{number} is even: ");
            Console.WriteLine(IsEven(number));
            Console.WriteLine();

            int number2 = 10;
            Console.WriteLine($"{number2} is even: ");
            Console.WriteLine(IsEven(number2));
            Console.WriteLine();

        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

    }
}
