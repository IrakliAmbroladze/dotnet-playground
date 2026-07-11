namespace PersonLib
{
    internal class Program
    {
        class Circle
        {
            const double Pi = 3.14159;
            public readonly double Radius;

            public double GetArea() { return Pi * Radius * Radius; }

            public Circle(double radius)
            {
                Radius = radius;
            }

        }
        static void Main()
        {
            Circle circle = new Circle(5);
            Console.WriteLine($"The area of the circle with radius {circle.Radius} is {circle.GetArea()}");

        }
    }
}