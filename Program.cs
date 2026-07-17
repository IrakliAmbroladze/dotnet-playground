namespace Georgia
{
    class Person
    {
        public string FirstName, LastName;
        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }

    class Student : Person
    {
        public double GPA;
        public Student(string FirstName, string LastName, double GPA) : base(FirstName, LastName)
        {
            this.GPA = GPA;
        }
    }
    internal class Program
    {
        static void Main()
        {
            Student student = new Student("Irakli", "Ambroladze", 3.5);
            Console.WriteLine($"{student.FirstName} {student.LastName} has GPA {student.GPA}");
        }
    }
}