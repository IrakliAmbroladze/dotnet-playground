namespace Georgia
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> cities = new LinkedList<string>();
            cities.AddLast("Tbilisi");
            cities.AddLast("Kutaisi");
            cities.AddLast("Batumi");
            cities.AddLast("Gori");

            cities.AddFirst("Telavi");

            if (cities.First != null)
            {
                cities.AddAfter(cities.First, "Mtskheta");
            }
            if (cities.Last != null)
            {
                cities.AddBefore(cities.Last, "Akhalkalaki");
            }
            cities.RemoveFirst();
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            };

        }
    }
}