namespace Georgia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }

            List<int> result = list.FindAll(i => i % 2 == 0);

            foreach (var item in result) { Console.WriteLine(item); }

        }
    }
}