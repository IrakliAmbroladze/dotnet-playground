namespace HomeWork
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int side = 3;

            PrintSquare(in side);
        }

        static void PrintSquare(in int number)
        {
            number = number + 1;
            Console.WriteLine(number * number);
        }

    }

}

