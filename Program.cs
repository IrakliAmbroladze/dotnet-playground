namespace Georgia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 4, 9, 15, 22, 30, 41, 56 };

            Predicate<int> isDivisibleByThree = number => number % 3 == 0;

            List<int> result = numbers.FindAll(isDivisibleByThree);

            foreach (int number in result)
            {
                Console.WriteLine(number);
            }
        }
    }
}