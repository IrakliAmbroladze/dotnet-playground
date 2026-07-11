namespace Georgia
{
    class Country
    {
        public long Population { get; set; }
        public double Area { get; set; }
        public Country(long population, double area)
        {
            Population = population;
            Area = area;
        }
        public static Country operator +(Country c1, Country c2)
        {
            return new Country(c1.Population + c2.Population, c1.Area + c2.Area);
        }
        public static bool operator >(Country c1, Country c2)
        {
            return c1.Population > c2.Population;
        }
        public static bool operator <(Country c1, Country c2)
        {
            return c1.Population < c2.Population;
        }
        public override string ToString()
        {
            return $"Population: {Population}, Area: {Area}";
        }
    }
    internal class Program
    {
        static void Main()
        {
            Country country1 = new Country(3700000, 69700);
            Country country2 = new Country(2800000, 29743);

            Console.WriteLine($"Country 1 has - {country1}");
            Console.WriteLine($"Country 2 has - {country2}");
            Console.WriteLine($"Union of countries is - {country1 + country2}");

            if (country1 > country2)
                Console.WriteLine("Country1 has a larger population.");
            else
                Console.WriteLine("Country1 does not have a larger population.");
        }
    }
}