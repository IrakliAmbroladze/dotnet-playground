using System;
using System.Linq;

namespace HomeWork_9_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 7;


            int result = Multiply(num1, num2);

            Console.WriteLine($"{num1} * {num2} = {result}");

        }

        static int Multiply(int a, int b) {
            return a * b;
        }
    }
}
