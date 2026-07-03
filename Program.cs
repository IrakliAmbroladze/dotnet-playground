namespace University
{
    class Human
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Profession { get; set; }

        public void Speak()
        {
            Console.WriteLine($"{this.Name} is speaking");
        }
        public Human(string name)
        {
            this.Name = name;
        }
    }
    class Program
    {
        static void Main()
        {
            Human human = new Human("Irakli");
            human.Speak();
        }
    }
}