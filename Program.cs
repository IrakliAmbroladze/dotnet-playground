namespace University
{
    class Computer
    {
        public string Brand { get; set; }
        public string Processor { get; set; }
        public bool IsOn { get; set; }
        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} computer is on.");
        }
        public Computer(string name)
        {
            this.Brand = name;
        }
    }
    class Program
    {
        static void Main()
        {
            Computer dell = new Computer("Dell");
            dell.TurnOn();
        }
    }
}