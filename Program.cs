namespace Georgia
{
    static


    internal class Program
    {

        static T FindMax<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty.");
            }

            T max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i].CompareTo(max) > 0)
                {
                    max = array[i];
                }
            }

            return max;
        }
        static void Main()
        {
            int[] numbers = { 10, 45, 3, 99, 27 };
            Console.WriteLine($"Max number: {FindMax(numbers)}");

            string[] names = { "Giorgi", "Irakli", "Ana", "Zura" };
            Console.WriteLine($"Max name: {FindMax(names)}");
        }
    }

}