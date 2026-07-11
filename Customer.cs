namespace Georgia
{
    class Customer
    {
        private string personalNumber;
        public string PersonalNumber
        {
            get { return personalNumber; }
            set
            {
                if (value != null && value.Length == 11)
                {
                    personalNumber = value;
                }
                else
                {
                    Console.WriteLine("Personal number must contain exactly 11 characters.");
                }
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountNumber { get; set; }

        public Customer(string firstName, string lastName,
                        string personalNumber, string accountNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PersonalNumber = personalNumber;
            AccountNumber = accountNumber;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Personal Number: {PersonalNumber}");
            Console.WriteLine($"Account Number: {AccountNumber}");
        }
    }
}