namespace PersonLib
{

    internal class Program
    {

        static void Main()
        {
            int value;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} * {n} = {i * n}");
            }
        }

    }
}