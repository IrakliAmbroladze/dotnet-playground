namespace PersonLib
{
    internal class Program
    {

        static void Main()
        {
            const double PI = 3.14;
            Console.WriteLine("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());
            double area = PI * radius * radius;
            Console.WriteLine($"The area of the circle wirh radius {radius} is {area}");
        }
    }
}