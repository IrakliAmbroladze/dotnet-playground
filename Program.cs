namespace University
{
    class Program
    {
        static void Main()
        {
            Person person = new Person();
            person.name = "Irakli";
            person.age = 35;

            Console.WriteLine($"{person.name} is {person.age} years old.");
        }
    }
}