namespace Georgia
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car() { Brand = "Toyota", EnginePower = 3.2 };
            car.ShowInfo();
            car.StartEngine();
        }
    }
}