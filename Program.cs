namespace Georgia
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("The following program makes math operations on two numbers.");
            Console.WriteLine();
            Console.Write("Enter number one: ");
            string inputOne = Console.ReadLine();
            Console.Write("Enter number two: ");
            string inputTwo = Console.ReadLine();

            try
            {
                double numberOne = Convert.ToDouble(inputOne);
                double numberTwo = Convert.ToDouble(inputTwo);
                Console.WriteLine();

                Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}");
                Console.WriteLine($"{numberOne} - {numberTwo} = {numberOne - numberTwo}");
                Console.WriteLine($"{numberOne} x {numberTwo} = {numberOne * numberTwo}");

                if (numberTwo == 0) { throw new DivideByZeroException(); }
                Console.WriteLine($"{numberOne} / {numberTwo} = {numberOne / numberTwo}");

                Console.WriteLine($"{numberOne} ^ {numberTwo} = {Math.Pow(numberOne, numberTwo)}");
                Console.WriteLine($"Calculations performed at {DateTime.Now}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter valid numbers.");
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown error.");
            }
        }
    }
}
