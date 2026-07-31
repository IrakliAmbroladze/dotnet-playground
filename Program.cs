namespace Georgia
{
    class Program
    {
        interface IRepository<T>
        {
            void Add(T item);
        }
        static void AddItem<T>(T item, IRepository<T> repository) where T : class { repository.Add(item); }
        class StringRepository : IRepository<string>
        {
            List<string> items = new List<string>();
            public void Add(string item)
            {
                items.Add(item);
                Console.WriteLine($"{item} added.");
                Console.WriteLine("List is: ");
                foreach (var item2 in items)
                {
                    Console.WriteLine(item2);
                }
                Console.WriteLine("------------");

            }

        }
        static void Main(string[] args)
        {
            StringRepository repository = new StringRepository();

            AddItem("Hello", repository);
            AddItem("World", repository);
        }
    }
}