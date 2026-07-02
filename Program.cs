namespace Georgia
{
    struct Point
    {
        public int X, Y;
    }

    class SecondPoint
    {
        public int X, Y;
        public SecondPoint(int x, int y) { X = x; Y = y; }
    }

    class Program
    {

        static void Main()
        {
            Point point;
            point.X = 8;
            point.Y = 10;



            Point testPoint = point;
            testPoint.X = 20;
            testPoint.Y = 21;
            Console.WriteLine(point.X);
            Console.WriteLine(point.Y);
            Console.WriteLine(testPoint.X);
            Console.WriteLine(testPoint.Y);

            SecondPoint point2 = new SecondPoint(4, 5);
            Console.WriteLine(point2.X);
            Console.WriteLine(point2.Y);
            SecondPoint testPoint2 = point2;
            testPoint2.X = 40;
            testPoint2.Y = 41;

            Console.WriteLine(point2.X);
            Console.WriteLine(point2.Y);
            Console.WriteLine(testPoint2.X);
            Console.WriteLine(testPoint2.Y);

        }

    }
}