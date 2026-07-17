namespace Georgia
{
    internal class Program
    {
        static void Main()
        {
            int a = 100;
            object boxedInt = a;
            Console.WriteLine("Boxed int:");
            Console.WriteLine(boxedInt.GetType());
            int backToInt = (int)boxedInt;
            Console.WriteLine();
            Console.WriteLine($"initial value is {a}");
            Console.WriteLine($"last value is {backToInt}");
            Console.WriteLine();

            bool boolValue = true;
            object boxedBoolValue = boolValue;
            Console.WriteLine("Boxed bool:");
            Console.WriteLine(boxedBoolValue.GetType());
            Console.WriteLine();

            decimal decimalValue = 10.5m;
            object boxedDecimalValue = decimalValue;
            Console.WriteLine("Boxed decimal:");
            Console.WriteLine(boxedDecimalValue.GetType());

        }
    }
}









