namespace HomeWork_9_10
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(SumOfDigits(124));
            Console.WriteLine(SumOfDigits(812));
        }

        static int SumOfDigits(int n)
        {
            if (n == 0)
                return 0;

            return (n % 10) + SumOfDigits(n / 10);
        }

    }
}
