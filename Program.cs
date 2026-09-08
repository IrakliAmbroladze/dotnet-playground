int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int max = int.MinValue;
int min = int.MaxValue;
int middle = 0;

if (a > max)
{
    max = a;
    if (b > max)
    {
        max = b;
        if (c > max)
        {
            max = c;

        }
    }
}

if (a < min)
{
    min = a;
    if (b < min)
    {
        min = b;
        if (c < min)
        {
            min = c;
        }
    }
}


if (a > min && max > a)
{
    middle = a;
}

if (b > min && max > b)
{
    middle = b;

}
if (c > min && max > c)
{
    middle = c;
}

Console.WriteLine($"max {max}");
Console.WriteLine($"min {min}");
Console.WriteLine($"{min} {middle} {max}");