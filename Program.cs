namespace PersonLib
{
    internal class Program
    {
        static class MathHelper
        {
            public static int Add(int a, int b)
            {
                return a + b;
            }
            public static int Multiply(int a, int b)
            {
                return a * b;
            }
        }
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter two numbers a and b: ");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(MathHelper.Add(a, b));
                Console.WriteLine(MathHelper.Multiply(a, b));
                Console.WriteLine();
            }

        }
    }
}