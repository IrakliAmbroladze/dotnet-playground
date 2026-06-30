using PersonLib;

namespace Georgia
{
    class Point
    {
        public int x;
        private int y;

        private void PrintX()
        {
            Console.WriteLine(x);
        }

        private void PrintY()
        {
            Console.WriteLine(y);
        }
    }
    internal class Program
    {

        static void Main()
        {
            Person person = new Person("Irakli", 35);

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }

    }
}