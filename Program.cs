namespace Georgia
{
    class Item
    {
        public string description { get; set; }
        public int count { get; set; }

        public void PrintDefault()
        {
            Console.WriteLine(this.count);
            Console.WriteLine(this.description);
        }
    }
    class Program
    {

        static void Main()
        {
            Item item = new Item();

            item.PrintDefault();


        }

    }
}