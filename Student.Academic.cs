namespace Georgia
{
    partial class Program
    {
        partial class Student
        {
            public double GPA { get; set; }
            public void ShowGrades()
            {
                Console.WriteLine($"This student ({FirstName} {LastName}) has grade {GPA}");
            }
        }
    }
}