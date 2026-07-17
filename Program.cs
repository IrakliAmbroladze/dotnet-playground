namespace Georgia
{
    class Person
    {
        public string FirstName, LastName, PersonalNumber;

        public Person(string FirstName, string LastName, string PersonalNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PersonalNumber = PersonalNumber;
        }
    }

    class Employee : Person
    {
        public double Salary;
        public Employee(string FirstName, string LastName, string PersonalNumber, double Salary) : base(FirstName, LastName, PersonalNumber)
        {
            this.Salary = Salary;
        }
    }
    class Teacher : Employee
    {
        public string Subject;
        public Teacher(string FirstName, string LastName, string PersonalNumber, double Salary, string Subject) : base(FirstName, LastName, PersonalNumber, Salary)
        {
            this.Subject = Subject;
        }
    }
    internal class Program
    {
        static void Main()
        {
            Teacher teacher = new Teacher("Emeliane", "Gogilidze", "12345678910", 10000, ".Net");
            Console.WriteLine($"{teacher.FirstName} {teacher.LastName} with ID {teacher.PersonalNumber} has salary of {teacher.Salary} and teaches {teacher.Subject}");
        }
    }
}