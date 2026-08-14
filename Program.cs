double a = 5;
double b = 5;
double c = 8;

Console.WriteLine($"sides: a = {a}, b = {b}, c = {c}\n");

if (a + b > c && a + c > b && b + c > a)
{
    Console.WriteLine("A triangle does exist");

    if (a == b && b == c)
    {
        Console.WriteLine("type: Equilateral(tolgverda)");
    }
    else if (a == b || a == c || b == c)
    {
        Console.WriteLine("type: Isosceles(tolgverda)");
    }
    else
    {
        Console.WriteLine("type: sides are different");
    }

    double perimeter = a + b + c;
    Console.WriteLine($"Perimeter: {perimeter}");
}
else
{
    Console.WriteLine("A triangle does not exist");
}