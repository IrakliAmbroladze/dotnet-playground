namespace PersonLib
{
    enum Colors : byte
    {
        Red, Green, Blue, Yellow, Black
    }
    internal class Program
    {

        static void Main()
        {
            foreach (Colors color in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine(color.ToString());
            }
        }

    }
}