namespace Georgia
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int, string> compareNumbers = (int x, int y) => (x > y) ? "First is greater" : (x < y) ? "Second is greater" : "Numbers are equal";

            Console.WriteLine(compareNumbers(7, 5));
            Console.WriteLine(compareNumbers(2, 5));
            Console.WriteLine(compareNumbers(5, 5));
        }
    }
}