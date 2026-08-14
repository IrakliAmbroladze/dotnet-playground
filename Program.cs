int[] numbers = { 42, 17, 8, 99, 23, 4, 65 };

Console.WriteLine("Initial array:");
Console.WriteLine(string.Join(", ", numbers));

int swapCount = SelectionSortDescending(numbers);
Console.WriteLine("\nSorted Array:");
Console.WriteLine(string.Join(", ", numbers));
Console.WriteLine($"\nNumber of swaps made: {swapCount}.");
static int SelectionSortDescending(int[] arr)
{
    int swaps = 0;
    int n = arr.Length;
    for (int i = 0; i < n - 1; i++)
    {
        int maxIndex = i;
        for (int j = i + 1; j < n; j++)
        {
            if (arr[j] > arr[maxIndex])
            {
                maxIndex = j;
            }
        }
        if (maxIndex != i)
        {
            int temp = arr[i];
            arr[i] = arr[maxIndex];
            arr[maxIndex] = temp;
            swaps++;
        }
    }
    return swaps;
}