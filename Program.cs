using System.Text;

namespace HomeWork
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("შეიყვანეთ რიცხვი: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                Console.WriteLine($"კონვერტაცია წარმატებულია: {result}");
            }
            else
            {
                Console.WriteLine("შეცდომა: ეს არ არის რიცხვი");
            }
        }

    }

}

