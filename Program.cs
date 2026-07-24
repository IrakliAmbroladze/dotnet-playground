namespace Georgia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }

            List<int> result = list.FindAll(
                delegate (int no) { return (no % 2 == 0); }
                );

            foreach (var item in result) { Console.WriteLine(item); }

        }
    }
}