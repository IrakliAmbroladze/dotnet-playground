namespace HomeWork
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(SumAll(1, 2, 3));
            Console.WriteLine();
            Console.WriteLine(SumAll(5, 10));
            Console.WriteLine();
            Console.WriteLine(SumAll());
            Console.WriteLine();
            Console.WriteLine(SumAll(new int[] { 4, 8, 15 }));
            Console.WriteLine();
        }

        static int SumAll(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double avg;
            if (numbers.Length > 0)
            {
                avg = sum / numbers.Length;
                Console.WriteLine($"average is: {avg}");
            }

            return sum;
        }

    }

}

