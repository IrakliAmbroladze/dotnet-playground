namespace Georgia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 3, 8, 12, 17, 24, 31, 40, 55 };

            Predicate<int> isDivisibleByFour = (int x) => x % 4 == 0;

            List<int> result = numbers.FindAll(isDivisibleByFour);

            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}