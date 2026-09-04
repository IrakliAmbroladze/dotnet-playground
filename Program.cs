using System.Globalization;

int[] numbers = new int[7];
Console.WriteLine("Enter 7 integers");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($" [{i + 1}]: ");
    numbers[i] = int.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
}
int even = 0;
int sumOfEvens = 0;
int odd = 0;
int sumOfOdds = 0;
int sum = 0;
double median = 0;

foreach (int n in numbers)
{
    if (n % 2 == 0)
    {
        sumOfEvens += n;
        even++;
    }

    if (n % 2 != 0)
    {
        sumOfOdds += n;
        odd++;
    }

    sum += n;
}

Array.Sort(numbers);
Array.Reverse(numbers);

if (numbers.Length % 2 == 1)
    median = numbers[numbers.Length / 2];
else
    median = (numbers[numbers.Length / 2 - 1] + numbers[numbers.Length / 2]) / 2.0;

Console.WriteLine($"even: {even}");
Console.WriteLine($"sumOfEvens: {sumOfEvens}");
Console.WriteLine($"odd: {odd}");
Console.WriteLine($"sumOfOdds: {sumOfOdds}");
Console.WriteLine($"sum: {sum}");

Console.WriteLine($"Sorted: {string.Join(", ", numbers)}");
Console.WriteLine($"median: {median}");