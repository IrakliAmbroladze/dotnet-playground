namespace Georgia
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> ticketQueue = new Queue<string>();
            Stack<string> actionHistory = new Stack<string>();

            ticketQueue.Enqueue("Irakli");
            ticketQueue.Enqueue("Luka");
            ticketQueue.Enqueue("Daviti");
            ticketQueue.Enqueue("Nino");
            ticketQueue.Enqueue("Tamari");
            actionHistory.Push(ticketQueue.Dequeue());
            actionHistory.Push(ticketQueue.Dequeue());
            Console.WriteLine($"Next in queue: {ticketQueue.Peek()}");
            Console.WriteLine($"Removed from history: {actionHistory.Pop()}");
            Console.WriteLine();
            Console.WriteLine("Remaining queue:");
            foreach (string customer in ticketQueue)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine();

            Console.WriteLine("History:");
            foreach (string customer in actionHistory)
            {
                Console.WriteLine(customer);
            }
        }
    }
}