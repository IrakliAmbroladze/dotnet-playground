using School.Students;

namespace School
{
    namespace Students
    {
        public class Student
        {
            public string Name;
        }
    }

    class Program
    {
        static void Main()
        {

            Student student = new Student();

            student.Name = "Giga";
            Console.WriteLine(student.Name);
        }
    }
}