namespace Georgia
{
    abstract class PaymentMethod
    {
        abstract public void Pay(decimal amount);
    }
    class CardPayment : PaymentMethod
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Card payment amount will be {amount * 1.2m}");
        }
    }
    class CashPayment : PaymentMethod
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Cash payment amount will be {amount * 1.1m}");
        }
    }
    class CryptoPayment : PaymentMethod
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Crypto payment amount will be {amount * 1.05m}");
        }
    }
    internal class Program
    {
        static void Main()
        {
            PaymentMethod payment = new CashPayment();
            payment.Pay(100);
        }
    }

}