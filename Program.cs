using System;
using System.Linq;

namespace HomeWork_9_10
{
    internal class Program
    {

       
      
        static void Main(string[] args)
        {
            int number = 5;
            int result = Factorial(number);

            Console.WriteLine($"Factorial of {number} is {result}");
        }

        static int Factorial(int number)
        {
            for (int i = number - 1; i > 0; i--)
            {
                number *= i;
            }
            return number;
        }
    }
}
