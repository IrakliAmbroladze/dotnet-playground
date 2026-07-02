namespace Georgia
{
    class Student
    {
        public string name { get; set; }
        public int grade { get; set; }
        public void Study()
        {
            Console.WriteLine($"{this.name} swavlobs");
        }
        public Student(string name)
        {
            this.name = name;
        }
    }
    class Program
    {

        static void Main()
        {
            Student student = new Student("Irakli");

            student.Study();


        }

    }
}