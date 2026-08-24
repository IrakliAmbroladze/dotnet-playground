using System.Diagnostics;

class Program
{
    const long Start = 1;
    const long End = 100_000_000;

    static long CalculateSum(long start, long end)
    {
        long sum = 0;

        for (long i = start; i <= end; i++)
        {
            sum += i;
        }

        return sum;
    }

    static async Task Main()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        long sequentialSum = CalculateSum(Start, End);

        stopwatch.Stop();

        Console.WriteLine($"Sequential sum: {sequentialSum}");
        Console.WriteLine($"Sequential time: {stopwatch.ElapsedMilliseconds} ms");

        long rangeSize = (End - Start + 1) / 4;
        stopwatch.Restart();

        Task<long>[] tasks =
        {
            Task.Run(() => CalculateSum(Start, Start + rangeSize - 1)),

            Task.Run(() => CalculateSum(
                Start + rangeSize,
                Start + rangeSize * 2 - 1)),

            Task.Run(() => CalculateSum(
                Start + rangeSize * 2,
                Start + rangeSize * 3 - 1)),

            Task.Run(() => CalculateSum(
                Start + rangeSize * 3,
                End))
        };

        long[] partialSums = await Task.WhenAll(tasks);

        stopwatch.Stop();

        for (int i = 0; i < partialSums.Length; i++)
        {
            Console.WriteLine($"Task {i + 1} partial sum: {partialSums[i]}");
        }

        long parallelSum = partialSums.Sum();

        Console.WriteLine($"Parallel total sum: {parallelSum}");
        Console.WriteLine($"Parallel time: {stopwatch.ElapsedMilliseconds} ms");

        Console.WriteLine();
        Console.WriteLine("Comparison:");

        if (parallelSum == sequentialSum)
        {
            Console.WriteLine("Results are equal.");
        }
        else
        {
            Console.WriteLine("Results are different!");
        }
    }
}