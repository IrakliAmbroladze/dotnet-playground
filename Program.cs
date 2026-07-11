namespace PersonLib
{
    internal class Program
    {
        class Money
        {
            decimal Amount;
            string Currency;

            public static bool operator >(Money a, Money b)
            {
                if (a.Currency != b.Currency)
                {
                    throw new InvalidOperationException(a.Currency + " and " + b.Currency);
                }
                return a.Amount > b.Amount;
            }
            public static bool operator <(Money a, Money b)
            {
                if (a.Currency != b.Currency)
                {
                    throw new InvalidOperationException(a.Currency + " and " + b.Currency);
                }
                return a.Amount < b.Amount;
            }
            public static Money operator +(Money a, decimal b)
            {
                return new Money(a.Amount + b, a.Currency);
            }
            public static Money operator ++(Money a)
            {
                return new Money(a.Amount + 1, a.Currency);
            }

            public Money(decimal value, string currency)
            {
                this.Amount = value;
                this.Currency = currency;
            }
            public override string ToString()
            {
                return $"{Amount} {Currency}";
            }

        }
        static void Main()
        {
            Money m1 = new Money(100, "GEL");
            Money m2 = new Money(150, "GEL");
            Console.WriteLine($"is {m1} < {m2}? {m1 < m2}");
            Console.WriteLine($"{m1} + 50 GEL = {m1 + 50}");
            Console.WriteLine($"increase {m1} by 1 GEL is {++m1}");
            Console.WriteLine();

            Money m3 = new Money(100, "USD");
            Console.WriteLine("Demonstation of comparing different currencies throws an error");
            Console.WriteLine();
            Console.WriteLine(m1 < m3);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}