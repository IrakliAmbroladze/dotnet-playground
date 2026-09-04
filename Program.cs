Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine() ?? "0");

PrintSquareTable(n);

static void PrintSquareTable(int n)
{
    Console.WriteLine();
    Console.WriteLine($"{"Number",-10} {"Square",-10} {"Cube",-10}");
    Console.WriteLine("------------------------------");

    for (int i = 1; i <= n; i++)
    {
        int square = i * i;
        int cube = i * i * i;

        Console.WriteLine($"{i,-10} {square,-10} {cube,-10}");
    }
}