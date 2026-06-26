namespace HomeWork_9_10
{
    internal class Program
    {
        enum Season : byte
        {
            Winter = 1, Spring, Summer, Autumn
        }

        static void Main()
        {
            Season current = Season.Summer;
            Console.WriteLine(current.ToString());
            Console.WriteLine((byte)current);
            Console.WriteLine();

            foreach (Season season in Enum.GetValues(typeof(Season)))
            {
                Console.WriteLine($"{season} = {(byte)season}");
            }
        }

    }
}