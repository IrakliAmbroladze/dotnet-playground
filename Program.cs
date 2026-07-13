using Accounts;

namespace Georgia
{

    internal class Program
    {
        static void Main()
        {
            User user = new User("Irakli", 35);
            Console.WriteLine($"{user.Name} is {user.Age} years old");
        }
    }
}