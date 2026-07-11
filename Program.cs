namespace Georgia
{
    internal class Program
    {
        static void Main()
        {
            Account account = new Account(
                 "GE29000000000000000000",
                 "GEL",
                 1500m);

            Customer customer = new Customer(
                "Irakli",
                "Ambroladze",
                "12345678901",
                account.AccountNumber);

            customer.Display();
            Console.WriteLine();

            account.Display();
        }
    }
}