namespace University
{
    struct Point
    {
        public int X, Y;

        public double Distance(Point other)
        {
            int dx = other.X - X;
            int dy = other.Y - Y;

            return Math.Sqrt(dx * dx + dy * dy);
        }
    }

    class Program
    {
        static void Main()
        {
            Point p1 = new Point { X = -1, Y = 3 };
            Point p2 = new Point { X = 2, Y = 7 };

            double distance = p1.Distance(p2);
            Console.WriteLine(distance);
            Console.WriteLine("some text");
        }
    }
}