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
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("შემოიტანეთ სეზონის სახელი (მაგ. summer, WINTER): ");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out Season parsedSeason))
            {
                Console.WriteLine($"სეზონი ცნობილია: {parsedSeason}");
            }
            else
            {
                Console.WriteLine("შეცდომა: ასეთი სეზონი არ არსებობს");
            }
        }

    }
}