namespace PersonLib
{
    internal class Program
    {
        static int Square(int x)
        {

            return x * x;
        }
        static void Main()
        {
            Console.WriteLine(Square(4));
            Console.WriteLine(Square(5));

        }
    }
}