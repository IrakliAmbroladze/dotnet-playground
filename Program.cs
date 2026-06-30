using PersonLib;

namespace Georgia
{
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