namespace University
{
    class Program
    {
        static void Main()
        {
            Person person1 = new Person();
            person1.name = "Irakli";
            person1.age = 35;

            Person person2 = new Person();
            person2.name = "Giga";
            person2.age = 40;

            person1.Talk();
            Console.WriteLine();

            person2.Talk();
            Console.WriteLine();

        }
    }
}