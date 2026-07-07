namespace PersonLib
{

    internal class Program
    {

        static void Main()
        {
            while (true)
            {
                var key = Console.ReadKey().Key;
                Console.WriteLine();
                Console.WriteLine((int)key);
            }
        }

    }
}