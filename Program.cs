namespace Georgia
{
    class Point
    {
        public int x;
        private int y;

        public void PrintX()
        {
            Console.WriteLine(x);
        }

        private void PrintY()
        {
            Console.WriteLine(y);
        }
    }
    internal class Program
    {

        static void Main()
        {
            Point point = new Point();

            point.x = 45;
            point.PrintX();

        }

    }
}