int a = 42; int b = 17; int c = 99; int d = 8;
Console.WriteLine($"Initial numbers: {a}, {b}, {c}, {d}\n");
int min, max;
if (a <= b && a <= c && a <= d)
    min = a;
else if (b <= c && b <= d)
    min = b;
else if (c <= d)
    min = c;
else
    min = d;

if (a >= b && a >= c && a >= d)
    max = a;
else if (b >= c && b >= d)
    max = b;
else if (c >= d)
    max = c;
else
    max = d;

Console.WriteLine($"Maximum: {max}");
Console.WriteLine($"Minimum:  {min}\n");

int n1 = a, n2 = b, n3 = c, n4 = d;

if (n1 > n2) { int temp = n1; n1 = n2; n2 = temp; }
if (n2 > n3) { int temp = n2; n2 = n3; n3 = temp; }
if (n3 > n4) { int temp = n3; n3 = n4; n4 = temp; }

if (n1 > n2) { int temp = n1; n1 = n2; n2 = temp; }
if (n2 > n3) { int temp = n2; n2 = n3; n3 = temp; }

if (n1 > n2) { int temp = n1; n1 = n2; n2 = temp; }

Console.WriteLine($"Sorted: {n1}, {n2}, {n3}, {n4}");