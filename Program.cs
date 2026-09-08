int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a + b > c)
{
    if (a + c > b)
    {
        if (b + c > a)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("tolgverda");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("tolferda");
            }
            else
            {
                Console.WriteLine("gverdebi sxvadasxva sigrdzisaa");
            }
        }
    }
    else
    {
        Console.WriteLine("araa samkutxedi");
    }
}