namespace Georgia
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> printResult = (int x, int y) =>
            {
                Console.WriteLine($"Sum: {x + y}");
            };
            printResult(15, 27);

            Action<string> printString = (string name) =>
            {
                Console.WriteLine($"Hello {name}!");
            };
            printString("Irakli");
        }
    }
}