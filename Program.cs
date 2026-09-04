int n = 8;
int[] numbers = new int[n];
Console.WriteLine("Enter 8 integers:");
for (int i = 0; i < n; i++)
{
    Console.Write($" [{i + 1}]: ");
    numbers[i] = int.Parse(Console.ReadLine() ?? "0");
}
int maxCount = 0;
for (int i = 0; i < n; i++)
{
    int count = 0;

    for (int j = 0; j < n; j++)
    {
        if (numbers[i] == numbers[j]) count++;
    }
    if (count > maxCount) maxCount = count;
}
Console.Write("Most frequent number(s): ");
for (int i = 0; i < n; i++)
{
    int count = 0;
    for (int j = 0; j < n; j++)
    {
        if (numbers[i] == numbers[j]) count++;
    }
    bool alreadyPrinted = false;
    for (int j = 0; j < i; j++)
    {
        if (numbers[i] == numbers[j])
        {
            alreadyPrinted = true;
            break;
        }
    }
    if (count == maxCount && !alreadyPrinted) Console.Write($"{numbers[i]} ");
}
HashSet<int> uniqueNumbers = new HashSet<int>(numbers);
Console.WriteLine();
Console.WriteLine($"Maximum frequency: {maxCount}");
Console.WriteLine($"Unique numbers: {uniqueNumbers.Count}");