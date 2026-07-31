namespace Georgia
{
    class Program
    {
        interface IVehicle
        {
            string Brand { get; set; }
            void Start();
            double CalculateFuelCost(double distanceKm, double consumptionPerKm);
        }
        class Car : IVehicle
        {
            public string Brand { get; set; } = string.Empty;
            public void Start() { Console.WriteLine($"{Brand} car has started!"); }
            public double CalculateFuelCost(double distanceKm, double consumptionPerKm)
            {
                return distanceKm * consumptionPerKm * 2.5;
            }
        }
        class Motorcycle : IVehicle
        {
            public string Brand { get; set; } = string.Empty;
            public void Start() { Console.WriteLine($"{Brand} motorcycle  has started!"); }
            public double CalculateFuelCost(double distanceKm, double consumptionPerKm)
            {
                return distanceKm * consumptionPerKm * 1.5;
            }
        }

        static void Main(string[] args)
        {
            Car car = new Car() { Brand = "Toyota" };
            Motorcycle motorcycle = new Motorcycle() { Brand = "Yamaha" };
            IVehicle[] vehicles = new IVehicle[] { car, motorcycle };
            foreach (IVehicle vehicle in vehicles)
            {
                vehicle.Start();
                Console.WriteLine($"Fuel cost: {vehicle.CalculateFuelCost(100, 0.7)}");
            }
        }
    }
}