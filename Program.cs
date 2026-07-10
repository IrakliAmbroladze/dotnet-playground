namespace PersonLib
{
    internal class Program
    {
        class BankAccount
        {
            private decimal balance;
            public decimal Balance
            {
                get { return balance; }
                set
                {
                    if (value >= 0)
                    {
                        balance = value;
                    }
                }
            }
            public void Deposit(decimal amount)
            {
                if (amount > 0)
                {
                    Balance += amount;
                }
            }
            public void Withdraw(decimal amount)
            {
                if (amount > 0 && Balance - amount >= 0)
                {
                    Balance -= amount;
                }
                else { Console.WriteLine("Not enough amount on deposit"); }
            }
        }

        static void Main()
        {
            BankAccount account = new BankAccount() { Balance = 500 };
            Console.WriteLine($"Starting Balance: {account.Balance}");
            Console.WriteLine();

            int withdraw = 700;
            Console.WriteLine($"Try to withdraw {withdraw}");
            account.Withdraw(withdraw);

            Console.WriteLine();
            Console.WriteLine($"Final Balance: {account.Balance}");
        }
    }
}