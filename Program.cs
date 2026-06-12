namespace HomeWork_9_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string input = Console.ReadLine();  
            CountCharacters(input);
        }

        static void CountCharacters(string input)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == ' ')
                {
                    continue;
                }
                else
                {
                    count++;
                }
            }
            Console.WriteLine($"The number of characters: {count}");
        }
    }
}
