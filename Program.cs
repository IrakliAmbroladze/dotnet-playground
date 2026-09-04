using System.Globalization;

Console.Write("Enter a positive integer: ");
int number = int.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

int originalNumber = number;
int digitCount = 0;
int temp = number;

while (temp > 0)
{
    digitCount++;
    temp /= 10;
}

temp = number;
int sum = 0;

Console.WriteLine("\nDigits:");

while (temp > 0)
{
    int digit = temp % 10;

    int power = (int)Math.Pow(digit, digitCount);
    sum += power;

    Console.WriteLine($"{digit}^{digitCount} = {power}");

    temp /= 10;
}
Console.WriteLine();
if (sum == originalNumber)
{
    Console.WriteLine($"{originalNumber} is an Armstrong number.");
}
else
{
    Console.WriteLine($"{originalNumber} is not an Armstrong number.");
}