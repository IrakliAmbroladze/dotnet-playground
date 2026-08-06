namespace Georgia
{
    partial class Program
    {
        partial class Student
        {
            public string FirstName { get; set; } = string.Empty;
            public string LastName { get; set; } = string.Empty;
            public int Age { get; set; }

            public Student(string name, string lastname, int age, double gpa)
            {
                FirstName = name;
                LastName = lastname;
                Age = age;
                GPA = gpa;
            }

        }
    }
}