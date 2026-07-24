namespace Georgia
{
    internal class Program
    {
        public delegate void AccountStateHandler(string message);
        class Account
        {
            public decimal Balance { get; set; }
            public AccountStateHandler? Notify;
            public Account(decimal balance) { Balance = balance; }
            public void Fill(decimal amount)
            {
                Balance += amount;
                Notify?.Invoke($"Deposited: {amount}. Balance: {Balance}");
            }

            public void Withdraw(decimal amount)
            {
                if (amount > Balance)
                {
                    Notify?.Invoke($"Withdrawal failed. Balance: {Balance}");
                    return;
                }
                Balance -= amount;
                Notify?.Invoke($"Withdrawn: {amount}. Balance: {Balance}");
            }
        }
        static void DisplayInfoConsole(string text) { Console.WriteLine(text); }
        static void DisplayInfoInFile(string text) { File.AppendAllText("C:\\Users\\Irakli\\OneDrive\\desktop\\AccountLogger.txt", text + Environment.NewLine); }

        static void Main(string[] args)
        {
            Account account = new Account(100);

            AccountStateHandler handler = DisplayInfoConsole;
            handler += DisplayInfoInFile;

            account.Notify = handler;

            account.Fill(50);
            account.Withdraw(30);

            Console.WriteLine();

            handler -= DisplayInfoInFile;

            account.Notify = handler;

            account.Fill(100);
        }
    }
}