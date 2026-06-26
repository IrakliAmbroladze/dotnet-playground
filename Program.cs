namespace HomeWork_9_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 1, b = 8;
            try
            {

                checked
                {
                    Console.WriteLine((byte)(a - b));
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine("We got Overflow exception");
            }
        }

    }
}
