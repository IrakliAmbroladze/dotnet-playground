namespace Georgia
{
    class Car
    {
        private bool isTankFull;
        private void FillTank()
        {
            Console.WriteLine("The tank is being filled ...");
            isTankFull = true;
            Console.WriteLine("The tank is filled!");

        }
        public void Drive()
        {
            if (!isTankFull)
            {
                Console.WriteLine("The tank is empty ...");
                FillTank();
            }
            Console.WriteLine("Driving ...");
            isTankFull = false;
        }
    }
    internal class Program
    {

        static void Main()
        {
            Car toyota = new Car();
            toyota.
        }

    }
}