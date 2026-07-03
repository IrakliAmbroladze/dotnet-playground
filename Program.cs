namespace Georgia
{
    class Point
    {
        public int X;
        private int Y = 12;

        private void PrintX()
        {
            Console.WriteLine($"X is {X}");
        }

        public void PrintY()
        {
            Console.WriteLine($"Y is {Y}");
        }

    }
    internal class Program
    {

        static void Main()
        {
            Point p = new Point();
            p.X = 10;
            Console.WriteLine($"print {p.X}");

            p.PrintY();
        }

    }
}