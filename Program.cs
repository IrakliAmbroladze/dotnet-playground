namespace Georgia
{
    class BankAccount
    {
        // ყველასთვის ხელმისაწვდომია
        public string AccountNumber = "GE123456789";

        // მხოლოდ ამ კლასსა და მის მემკვიდრეებს
        protected decimal Balance = 5000;

        // მხოლოდ ამ კლასის შიგნით
        private int PinCode = 1234;

        // მხოლოდ ამავე Assembly-ში
        internal string BankName = "Bank of Georgia";
    }

    class SavingsAccount : BankAccount
    {
        public void Display()
        {
            // შესაძლებელია, რადგან public-ია
            Console.WriteLine(AccountNumber);

            // შესაძლებელია, რადგან protected-ია
            Console.WriteLine(Balance);

            // შეუძლებელია, რადგან private-ია
            // Console.WriteLine(PinCode);

            // შესაძლებელია, რადგან internal-ია
            // (ორივე კლასი ერთ Assembly-შია)
            Console.WriteLine(BankName);
        }
    }

    internal class Program
    {
        static void Main()
        {
            SavingsAccount account = new SavingsAccount();
            account.Display();
        }
    }
}