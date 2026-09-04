int[] numbers = { 15, 4, 27, 8, 2, 19 };

int min = numbers[0];
int max = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] < min)
        min = numbers[i];

    if (numbers[i] > max)
        max = numbers[i];
}

Console.WriteLine($"Minimum: {min}");
Console.WriteLine($"Maximum: {max}");