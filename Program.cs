namespace Georgia
{
    abstract class Person
    {
        public string Name { get; set; }

        public Person(string Name)
        {
            this.Name = Name;
        }

        public abstract void Introduce();
    }
    class Student : Person
    {
        double GPA { get; set; }

        public Student(string Name, double GPA) : base(Name)
        {
            this.GPA = GPA;
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hello, I am a student {Name}, my GPA is {GPA}");
        }
    }
    class Teacher : Person
    {
        string Subject { get; set; }

        public Teacher(string Name, string Subject) : base(Name)
        {
            this.Subject = Subject;
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hello, I am a teacher {Name}, I teach {Subject}");
        }
    }


    internal class Program
    {
        public static void HelloMethod(Person person)
        {
            person.Introduce();
        }
        static void Main()
        {
            Student student = new Student("Irakli", 3.5);
            Teacher teacher = new Teacher("Emeliane", ".Net");
            HelloMethod(student);
            HelloMethod(teacher);
        }
    }
}









