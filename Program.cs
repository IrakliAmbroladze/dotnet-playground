class Program
{
    static void Main()
    {
        while (true)
        {
            int inp = int.Parse(Console.ReadLine());
            if (inp < 0)
            {
                inp = -inp;
            }
            int tempor = inp;
            int even = 0;
            int odd = 0;

            while (tempor > 0)
            {
                int digit = tempor % 10;

                if (digit % 2 == 0)
                    even++;

                if (digit % 2 != 0)
                    odd++;


                tempor /= 10;
            }

            Console.WriteLine($"even: {even}");
            Console.WriteLine($"odd: {odd}");
        }
    }
}