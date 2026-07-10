namespace PersonLib
{
    internal class Program
    {
        class Temperature
        {
            double celsius;
            public double Celsius
            {
                get { return celsius; }
                set
                {
                    if (value >= -50 && value < 50)
                    {

                        celsius = value;
                    }
                    else
                    {
                        celsius = 0;
                    }

                }
            }
        }
        static double ToFahrenheit(double C)
        {
            double F = C * 9 / 5 + 32;
            return F;
        }
        static void Main()
        {
            double C = 100;
            Temperature temperature = new Temperature() { Celsius = C };
            if (C != temperature.Celsius)
            {
                Console.WriteLine("Temperature celsius is out of range");
            }
            Console.WriteLine($"Value in celsius is {temperature.Celsius}");
            Console.WriteLine($"Value in farenheit is {ToFahrenheit(temperature.Celsius)}");
        }
    }
}