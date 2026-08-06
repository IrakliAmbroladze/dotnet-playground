namespace Georgia
{
    class Program
    {
        public static int CountWords(string input)
        {
            //int count = input.Split().Length;
            int count = 0;
            foreach (string word in input.Split())
            {
                if (word.Length > 0)
                {
                    count++;
                }
            }

            Console.WriteLine(string.Join(", ", input.Split()));
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CountWords("Hello there"));
            Console.WriteLine(CountWords("Hello        dotnet at SkillWill"));
        }
    }
}