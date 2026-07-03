namespace University
{
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public void Talk()
        {
            Console.WriteLine($"Hello I am {this.name} and my age is {this.age}");
        }

        public Person()
        {
            this.name = "Someone";
            this.age = 100;
        }
        public Person(string name)
        {
            this.name = name;
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}