namespace Georgia
{
    partial class Program
    {
        partial class Car
        {
            public string Brand { get; set; }
            public double EnginePower { get; set; }

            public void StartEngine()
            {
                Console.WriteLine($"{Brand} has started");
            }

        }
    }
}