namespace PersonLib
{
    internal class Program
    {
        class Vector2D
        {
            double X, Y;
            public static Vector2D operator +(Vector2D v1, Vector2D v2)
            {
                return new Vector2D(v1.X + v2.X, v1.Y + v2.Y);
            }
            public static Vector2D operator -(Vector2D v1, Vector2D v2)
            {
                return new Vector2D(v1.X - v2.X, v1.Y - v2.Y);

            }
            public static Vector2D operator -(Vector2D v1)
            {
                return new Vector2D(-v1.X, -v1.Y);
            }
            public override string ToString()
            {
                return ($"({X},{Y})");
            }
            public Vector2D(double x, double y)
            {
                X = x;
                Y = y;
            }

        }
        static void Main()
        {
            Vector2D v1 = new Vector2D(3, 4);
            Vector2D v2 = new Vector2D(1, 2);
            Console.WriteLine((v1 + v2).ToString());
            Console.WriteLine((v1 - v2).ToString());
            Console.WriteLine((-v1).ToString());

        }
    }
}