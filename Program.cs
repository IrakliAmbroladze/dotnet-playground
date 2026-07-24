namespace Georgia
{
    internal class Program
    {
        class InsufficientFundsException : Exception
        {
            public InsufficientFundsException(string message) : base(message) { }
        }
        static decimal Withdraw(decimal balance, decimal amount)
        {
            if (amount > balance) throw new InsufficientFundsException("Not enough money");
            return balance - amount;
        }

        static void Main(string[] args)
        {
            decimal balance = 100;
            decimal amount = 250;
            try
            {
                decimal remaining = Withdraw(balance, amount);
                Console.WriteLine($"Remaining balance: {remaining}");

                int x = 10;
                int y = 0;
                Console.WriteLine(x / y);
            }
            catch (InsufficientFundsException ex) when (amount - balance > 100)
            {
                Console.WriteLine("More than 100 is shortage.");
                Console.WriteLine(ex.Message);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}