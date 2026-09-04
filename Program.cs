int[] first = { 5, 2, 8, 1 };
int[] second = { 7, 3, 6, 4 };

int[] result = new int[first.Length + second.Length];

for (int i = 0; i < first.Length; i++)
{
    result[i] = first[i];
}

for (int i = 0; i < second.Length; i++)
{
    result[first.Length + i] = second[i];
}

Array.Sort(result);

Console.WriteLine("Merged and sorted array:");

foreach (int number in result)
{
    Console.Write($"{number} ");
}
Console.WriteLine();