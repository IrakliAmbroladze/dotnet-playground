namespace HomeWork_9_10
{
    internal class Program
    {



        static void Main(string[] args)
        {
            int number = 8;
            int result = Factorial(number);

            Console.WriteLine($"Factorial of {number} is {result}");
            Console.WriteLine($"Factorial of 0 is {Factorial(0)}");
            Console.WriteLine($"Factorial of 1 is {Factorial(1)}");
        }

        static int Factorial(int number)
        {
            if (number == 0 || number == 1)
                return 1;

            return number * Factorial(number - 1);
        }
    }
}
