namespace HomeWork_9_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            PrintArray(arr, 0);
        }

        static void PrintArray(int[] arr, int index)
        {
            if (index >= arr.Length)
                return;

            Console.WriteLine(arr[index]);

            PrintArray(arr, index + 1);
        }

    }
}
