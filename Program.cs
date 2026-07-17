namespace Georgia
{
    abstract class Vehicle
    {
        public string Brand;
        public Vehicle(string brand)
        {
            Brand = brand;
        }
        public abstract void Move();
    }
    class Car : Vehicle
    {
        public Car(string brand) : base(brand) { }
        public override void Move()
        {
            Console.WriteLine("Manqana modzraobs benzinze");
        }
    }
    class Bicycle : Vehicle
    {
        public Bicycle(string brand) : base(brand) { }
        public override void Move()
        {
            Console.WriteLine("Velosipedi modzraobs fekhebis dzalit");
        }
    }


    internal class Program
    {
        static void Main()
        {
            Vehicle car = new Car("Toyota");
            car.Move();
            Console.WriteLine();
            Car carDowncast = (Car)car;
            Console.WriteLine(carDowncast.Brand);
        }
    }
}









