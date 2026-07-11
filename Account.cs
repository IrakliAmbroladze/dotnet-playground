namespace Georgia
{

    class Account
    {

        public string accountNumber;
        public string AccountNumber
        {
            get { return accountNumber; }
            set
            {
                if (value != null && value.Length == 22)
                {
                    accountNumber = value;
                }
                else
                {
                    Console.WriteLine("Account number must contain exactly 22 characters.");
                }
            }
        }
        public string Currency { get; set; }

        private decimal amount;

        public decimal Amount
        {
            get { return amount; }
            set
            {
                if (value >= 0)
                    amount = value;
            }
        }

        public Account(string accountNumber, string currency, decimal amount)
        {
            AccountNumber = accountNumber;
            Currency = currency;
            Amount = amount;
        }

        public void Display()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Currency: {Currency}");
            Console.WriteLine($"Balance: {Amount}");
        }
    }
}