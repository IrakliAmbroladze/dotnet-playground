using System.Diagnostics;

int size = 100_000;
int[] originalArray = new int[size];
Random rand = new Random();

for (int i = 0; i < size; i++)
{
    originalArray[i] = rand.Next(1, 1_000_000);
}
int target = originalArray[size / 2];
Console.WriteLine($"Searching for target: {target} in an array of {size:N0} elements.\n");

Stopwatch sw = Stopwatch.StartNew();

int linearIndex = LinearSearch(originalArray, target);
sw.Stop();
long linearTicks = sw.ElapsedTicks;

Console.WriteLine($"[Linear Search]");
Console.WriteLine($"Index Found : {linearIndex}");
Console.WriteLine($"Time Taken  : {linearTicks} ticks ({sw.Elapsed.TotalMicroseconds:F2} μs)\n");

int[] sortedArray = (int[])originalArray.Clone();
Array.Sort(sortedArray);

sw.Restart();

int binaryIndex = BinarySearchManual(sortedArray, target);
sw.Stop();
long binaryTicks = sw.ElapsedTicks;
Console.WriteLine($"[Binary Search (Manual)]");
Console.WriteLine($"Index Found : {binaryIndex} (in sorted array)");
Console.WriteLine($"Time Taken  : {binaryTicks} ticks ({sw.Elapsed.TotalMicroseconds:F2} μs)\n");

Console.WriteLine($"Binary Search was approx. {(double)linearTicks / Math.Max(binaryTicks, 1):F1}x faster for the search phase.");

static int LinearSearch(int[] arr, int target)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == target)
            return i;
    }
    return -1;
}

static int BinarySearchManual(int[] sortedArr, int target)
{
    int left = 0;
    int right = sortedArr.Length - 1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (sortedArr[mid] == target)
            return mid;

        if (sortedArr[mid] < target)
            left = mid + 1;
        else
            right = mid - 1;
    }

    return -1;
}