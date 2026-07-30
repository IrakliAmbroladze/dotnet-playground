namespace Georgia
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> printIfEven = (int value) =>
            {
                if (value % 2 == 0)
                {
                    Console.WriteLine(value);
                }

            };
            printIfEven(7);
            printIfEven(12);
            printIfEven(21);
            printIfEven(22);


        }
    }
}