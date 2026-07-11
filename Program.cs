namespace PersonLib
{
    internal class Program
    {
        class Fraction
        {
            int Numerator;
            int Denominator;
            public static Fraction operator *(Fraction a, Fraction b)
            {
                return new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
            }
            public static Fraction operator /(Fraction a, Fraction b)
            {
                if (b.Numerator == 0) throw new ArgumentException("can't devide by zero");
                return new Fraction(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
            }

            public static bool operator ==(Fraction a, Fraction b)
            {
                return a.Numerator * b.Denominator == a.Denominator * b.Numerator;
            }

            public static bool operator !=(Fraction a, Fraction b)
            {
                return a.Numerator * b.Denominator != a.Denominator * b.Numerator;
            }
            public override bool Equals(object? obj)
            {
                if (obj is Fraction other)
                {
                    return this == other;
                }

                return false;
            }
            public override int GetHashCode()
            {
                return HashCode.Combine(Numerator, Denominator);
            }
            public Fraction(int numerator, int denominator)
            {
                if (denominator == 0)
                    throw new ArgumentException("Denominator cannot be zero.");
                Numerator = numerator;
                Denominator = denominator;
            }
            public override string ToString()
            {
                if (Numerator == Denominator)
                {
                    return "1";
                }
                return $"{Numerator}/{Denominator}";
            }
        }
        static void Main()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(2, 4);
            Console.WriteLine($"does {f1} equal to {f2}? {f1 == f2}");
            Console.WriteLine($"{f1} x {f2} = {f1 * f2}");
            Console.WriteLine($"{f1} / {f2} = {f1 / f2}");
        }
    }
}