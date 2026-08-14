Console.WriteLine("Recursive Power");
Console.WriteLine($"2^10  = {Power(2, 10)}");
Console.WriteLine($"5^3   = {Power(5, 3)}");
Console.WriteLine($"7^0   = {Power(7, 0)}");
Console.WriteLine($"3^4   = {Power(3, 4)}");

Console.WriteLine();

Console.WriteLine("Recursive GCD");
Console.WriteLine($"GCD(48, 18)  = {Gcd(48, 18)}");
Console.WriteLine($"GCD(101, 10)  = {Gcd(101, 10)}");
Console.WriteLine($"GCD(56, 98)   = {Gcd(56, 98)}");
Console.WriteLine($"GCD(270, 192) = {Gcd(270, 192)}");

static long Power(int baseNum, int exponent)
{
    if (exponent < 0)
        throw new ArgumentException("Exponent must be non-negative.");
    if (exponent == 0)
        return 1;
    return baseNum * Power(baseNum, exponent - 1);
}

static int Gcd(int a, int b)
{
    a = Math.Abs(a);
    b = Math.Abs(b);
    if (b == 0)
        return a;
    return Gcd(b, a % b);
}