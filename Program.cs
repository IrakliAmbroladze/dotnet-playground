namespace PersonLib
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 1)
            {
                Console.WriteLine("n must be greater than 1");
                return;
            }

            bool isMartivi = true;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isMartivi = false;
                    break;
                }
            }

            if (isMartivi)
                Console.WriteLine($"{n} is Martivi");
            else
                Console.WriteLine($"{n} is Rtuli");
        }
    }
}