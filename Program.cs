Thread odd = new(OddThread);
Thread even = new(EvenThread);

odd.Start();
even.Start();

odd.Join();
even.Join();

Console.WriteLine("dasasruli");
static void OddThread()
{
    for (int i = 0; i <= 15; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine($"OddThread: {i}");
            Thread.Sleep(500);
        }

    }
}


static void EvenThread()
{
    for (int i = 0; i <= 15; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine($"EvenThread: {i}");
            Thread.Sleep(500);

        }

    }
}