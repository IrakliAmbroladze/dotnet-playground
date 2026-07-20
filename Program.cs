namespace Georgia
{
    abstract class Person
    {
        abstract public void Talk();
    }
    class Subject
    {
        public string Name { get; set; } = string.Empty;
        public int Hours { get; set; }
    }

    class Teacher : Person
    {
        public string Name { get; set; }
        public Subject Subject { get; set; }

        public Teacher(string name, Subject subject)
        {
            Name = name;
            Subject = subject;
        }
        public override void Talk()
        {
            Console.WriteLine($"Teacher {Name} teaches {Subject.Name}");
        }


    }
    internal class Program
    {
        static void Main()
        {
            Subject subject = new Subject();
            subject.Name = ".NET";
            subject.Hours = 4;
            Person teacher = new Teacher("Emeliane", subject);
            teacher.Talk();
        }
    }

}