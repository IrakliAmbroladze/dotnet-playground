namespace Georgia
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int size = 10;
            List<int> list = new List<int>();
            for (int i = 0; i < size; i++)
            {
                list.Add(random.Next(1, 100));
                Console.WriteLine($"Capacity {list.Capacity}");
                Console.WriteLine($"Count {list.Count}");
            }
            Console.WriteLine();
            list.Sort();
            Console.Write("List numbers: ");

            foreach (int i in list) { Console.Write($"{i}, "); }
            List<int> evenList = list.FindAll(x => x % 2 == 0);

            Console.WriteLine();

            Console.Write("Even numbers: ");
            foreach (int i in evenList) { Console.Write($"{i}, "); }
            Console.WriteLine();
            list.TrimExcess();
            Console.WriteLine($"Capacity after TrimExcess {list.Capacity}");
            Console.WriteLine($"Count after TrimExcess {list.Count}");

        }
    }
}