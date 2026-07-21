namespace Georgia
{
    abstract class Person
    {
    }

    class Client : Person
    {
        public decimal Balance { get; set; }
        public Client(decimal amount)
        {
            Balance = amount;
        }

    }
    class Employee : Person { }
    internal class Program
    {
        static void Main()
        {
            try
            {
                Person person = new Client(100);
                Client downcastPerson = (Client)person;
                Console.WriteLine(downcastPerson.Balance);
                Employee secondDowncastPerson = (Employee)person;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

}