namespace HomeWork
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            Console.WriteLine($"before: x is {x}, y is {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"after: x is {x}, y is {y}");
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

    }

}

