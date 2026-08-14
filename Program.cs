using System.Diagnostics;

int maxNumber = 2_000_000;
var numbers = Enumerable.Range(1, maxNumber);

Stopwatch sw = Stopwatch.StartNew();

int linqCount = numbers
    .Where(IsPrime)
    .Count();

sw.Stop();
long linqTime = sw.ElapsedMilliseconds;

Console.WriteLine($"With LINQ found: {linqCount} | time: {linqTime} ms");

sw.Restart();
int plinqCount = numbers
    .AsParallel()
    .Where(IsPrime)
    .Count();
sw.Stop();
long plinqTime = sw.ElapsedMilliseconds;
Console.WriteLine($"With PLINQ found: {plinqCount} | time: {plinqTime} ms");

sw.Restart();
int plinq4Count = numbers
    .AsParallel()
    .WithDegreeOfParallelism(4)
    .Where(IsPrime)
    .Count();
sw.Stop();
long plinq4Time = sw.ElapsedMilliseconds;
Console.WriteLine($"With PLINQ4 found: {plinq4Count} | time: {plinq4Time} ms");

static bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;

    int boundary = (int)Math.Floor(Math.Sqrt(number));

    for (int i = 3; i <= boundary; i += 2)
    {
        if (number % i == 0)
            return false;
    }

    return true;
}