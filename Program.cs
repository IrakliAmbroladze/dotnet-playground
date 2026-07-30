namespace Georgia
{
    class Program
    {
        interface IFlyable
        {
            void Fly();
        }
        interface ISwimmable
        {
            void Swim();
        }
        class Duck : IFlyable, ISwimmable
        {
            public void Fly()
            {
                Console.WriteLine("Can fly");
            }
            public void Swim()
            {
                Console.WriteLine("Can swim");
            }
        }
        static void Main(string[] args)
        {

            Duck duck = new Duck();
            duck.Swim();
            duck.Fly();
        }
    }
}