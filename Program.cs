using System;
using System.Linq;

namespace HomeWork_9_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(2,7));
            Console.WriteLine(Sum(2.5,7));
            Console.WriteLine(Sum(2,7,6));

        }

        static int	Sum(int a, int b)
        {
            return a + b;
        } 
        static double Sum(double a, double b)
        {
            return a + b;
        }
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

    }
}
