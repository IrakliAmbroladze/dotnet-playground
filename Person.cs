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
    }
}